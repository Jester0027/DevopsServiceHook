using MediatR;

namespace DevopsServiceHook.Commands;

public abstract record DevopsCommand(AzureDevopsMessage.Models.AzureDevopsMessage Message) : IRequest;