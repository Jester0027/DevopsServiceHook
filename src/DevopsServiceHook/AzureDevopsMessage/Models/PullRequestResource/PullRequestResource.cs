using System.Collections.Immutable;

namespace DevopsServiceHook.AzureDevopsMessage.Models.PullRequestResource;

public sealed record PullRequestResource
{
    public Repository Repository { get; set; }
    public int PullRequestId { get; set; }
    public string Status { get; set; }
    public User CreatedBy { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime ClosedDate { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string SourceRefName { get; set; }
    public string TargetRefName { get; set; }
    public string MergeStatus { get; set; }
    public Guid MergeId { get; set; }
    public Commit LastMergeSourceCommit { get; set; }
    public Commit LastMergeTargetCommit { get; set; }
    public Commit LastMergeCommit { get; set; }
    public ImmutableHashSet<Reviewer> Reviewers { get; set; }
    public ImmutableHashSet<Commit> Commits { get; set; }
    public string Url { get; set; }
}