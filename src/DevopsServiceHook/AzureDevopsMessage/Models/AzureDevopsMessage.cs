using System.Text.Json.Serialization;
using DevopsServiceHook.AzureDevopsMessage.Enums;
using DevopsServiceHook.Commands;

namespace DevopsServiceHook.AzureDevopsMessage.Models;

/// <summary>
/// Azure Devops service hook event message
/// </summary>
/// https://learn.microsoft.com/en-us/azure/devops/service-hooks/events?toc=%2Fazure%2Fdevops%2Fmarketplace-extensibility%2Ftoc.json&view=azure-devops
public sealed record AzureDevopsMessage
{
    public Guid Id { get; set; }
    public EventType EventType { get; set; } = null!;
    public Guid PublisherId { get; set; }
    public string Scope { get; set; } = null!;
    public DetailedMessage DetailedMessage { get; set; } = null!;
    public PullRequestResource.PullRequestResource Resource { get; set; } = null!;
    public string ResourceVersion { get; set; } = null!;
    public ResourceContainers ResourceContainers { get; set; } = null!;
    public DateTime CreatedDate { get; set; }

    public AzureDevopsMessage()
    {
    }

    public DevopsCommand ToCommand()
    {
        return EventType.Name switch
        {
            nameof(EventType.PullRequestCreated) => new PullRequestCreatedCommand(this),
            _ => throw new NotImplementedException()
        };
    }
}