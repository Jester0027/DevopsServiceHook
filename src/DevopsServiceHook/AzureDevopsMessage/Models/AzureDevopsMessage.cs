using DevopsServiceHook.AzureDevopsMessage.Enums;

namespace DevopsServiceHook.AzureDevopsMessage.Models;

/// <summary>
/// Azure Devops service hook event message
/// </summary>
/// https://learn.microsoft.com/en-us/azure/devops/service-hooks/events?toc=%2Fazure%2Fdevops%2Fmarketplace-extensibility%2Ftoc.json&view=azure-devops
public sealed record AzureDevopsMessage
{
    public Guid Id { get; set; }
    public EventType EventType { get; set; }
    public Guid PublisherId { get; set; }
    public string Scope { get; set; }
    public DetailedMessage DetailedMessage { get; set; }
    public PullRequestResource.PullRequestResource Resource { get; set; }
    public string ResourceVersion { get; set; }
    public ResourceContainers ResourceContainers { get; set; }
    public DateTime CreatedDate { get; set; }
}