using MediatR;

namespace DevopsServiceHook.Commands;

public sealed record PullRequestCreatedCommand(AzureDevopsMessage.Models.AzureDevopsMessage Message) : DevopsCommand(Message);

internal sealed record PullRequestCreatedCommandHandler : IRequestHandler<PullRequestCreatedCommand>
{
    public Task<Unit> Handle(PullRequestCreatedCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}