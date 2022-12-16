using DevopsServiceHook.AzureDevopsMessage.Models.PullRequestResource;

namespace DevopsServiceHook.AzureDevopsMessage.Models;

public sealed record ResourceContainers
{
    public ResourceContainerCollection Collection { get; set; }
    public Account Account { get; set; }
    public Project Project { get; set; }
}

public sealed record Account
{
    public Guid Id { get; set; }
}

public sealed record ResourceContainerCollection
{
    public Guid Id { get; set; }
}