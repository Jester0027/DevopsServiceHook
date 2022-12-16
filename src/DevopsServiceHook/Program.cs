using System.Reflection;
using System.Text.Json.Serialization;
using Ardalis.SmartEnum.SystemTextJson;
using DevopsServiceHook._Setup.Services;
using DevopsServiceHook.AzureDevopsMessage.Enums;
using DevopsServiceHook.Swagger;
using MediatR;

namespace DevopsServiceHook;

internal static class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(options => { options.SchemaFilter<SmartEnumSchemaFilter>(); });
        builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
        builder.Services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.Converters.Add(new SmartEnumValueConverter<EventType, string>());
            options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        });

        builder.Services.AddHangfire(builder.Configuration);

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        await app.RunAsync();
    }
}