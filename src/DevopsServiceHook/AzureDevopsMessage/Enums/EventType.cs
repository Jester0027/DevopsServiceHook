using System.Diagnostics;
using Ardalis.SmartEnum;
using DevopsServiceHook.Commands;
using MediatR;

namespace DevopsServiceHook.AzureDevopsMessage.Enums;

public sealed class EventType : SmartEnum<EventType, string>
{
    public static readonly EventType BuildComplete = new(nameof(BuildComplete), "build.complete");
    public static readonly EventType ReleaseAbandoned = new(nameof(ReleaseAbandoned), "ms.vss-release.release-abandoned-event");
    public static readonly EventType ReleaseCreated = new(nameof(ReleaseCreated), "ms.vss-release.release-created-event");
    public static readonly EventType ReleaseDeploymentApprovalCompleted = new(nameof(ReleaseDeploymentApprovalCompleted), "ms.vss-release.deployment-approval-completed-event");
    public static readonly EventType ReleaseDeploymentApprovalPending = new(nameof(ReleaseDeploymentApprovalPending), "ms.vss-release.deployment-approval-pending-event");
    public static readonly EventType ReleaseDeploymentCompleted = new(nameof(ReleaseDeploymentCompleted), "ms.vss-release.deployment-completed-event");
    public static readonly EventType ReleaseDeploymentStarted = new(nameof(ReleaseDeploymentStarted), "ms.vss-release.deployment-started-event");
    public static readonly EventType RunStateChanged = new(nameof(RunStateChanged), "ms.vss-pipelines.run-state-changed-event");
    public static readonly EventType RunStageStateChanged = new(nameof(RunStageStateChanged), "ms.vss-pipelines.stage-state-changed-event");
    public static readonly EventType RunStageWaitingForApproval = new(nameof(RunStageWaitingForApproval), "ms.vss-pipelinechecks-events.approval-pending");
    public static readonly EventType CodeCheckedIn = new(nameof(CodeCheckedIn), "tfvc.checkin");
    public static readonly EventType CodePushed = new(nameof(CodePushed), "git.push");
    public static readonly EventType PullRequestCreated = new(nameof(PullRequestCreated), "git.pullrequest.created");
    public static readonly EventType PullRequestMergeCommitCreated = new(nameof(PullRequestMergeCommitCreated), "git.pullrequest.merged");
    public static readonly EventType PullRequestUpdated = new(nameof(PullRequestUpdated), "git.pullrequest.updated");
    public static readonly EventType WorkItemCreated = new(nameof(WorkItemCreated), "workitem.created");
    public static readonly EventType WorkItemDeleted = new(nameof(WorkItemDeleted), "workitem.deleted");
    public static readonly EventType WorkItemRestored = new(nameof(WorkItemRestored), "workitem.restored");
    public static readonly EventType WorkItemUpdated = new(nameof(WorkItemUpdated), "workitem.updated");
    public static readonly EventType WorkItemCommented = new(nameof(WorkItemCommented), "workitem.commented");

    public EventType(string name, string value) : base(name, value)
    {
    }
}