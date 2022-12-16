using Hangfire;
using MediatR;

namespace DevopsServiceHook.Extensions;

public static class MediatorExtensions
{
    public static void Enqueue(this IMediator mediator, IRequest request)
    {
        var backgroundJobClient = new BackgroundJobClient();
        backgroundJobClient.Enqueue<MediatorHangfireBridge>(x => x.Send(request));
    }
}