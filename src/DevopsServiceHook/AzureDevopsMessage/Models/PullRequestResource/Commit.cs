namespace DevopsServiceHook.AzureDevopsMessage.Models.PullRequestResource;

public sealed record Commit
{
    public Guid CommitId { get; set; }
    public string Url { get; set; }
}