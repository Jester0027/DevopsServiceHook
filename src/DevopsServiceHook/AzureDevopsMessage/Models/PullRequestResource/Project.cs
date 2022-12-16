namespace DevopsServiceHook.AzureDevopsMessage.Models.PullRequestResource;

public sealed record Project
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string State { get; set; }
}