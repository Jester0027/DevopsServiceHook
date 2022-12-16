namespace DevopsServiceHook.AzureDevopsMessage.Models.PullRequestResource;

public record User
{
    public Guid Id { get; set; }
    public string DisplayName { get; set; }
    public string UniqueName { get; set; }
    public string Url { get; set; }
    public string ImageUrl { get; set; }
}

public sealed record Reviewer : User
{
    public string ReviewerUrl { get; set; }
    public int Vote { get; set; }
    public bool IsContainer { get; set; }
}
