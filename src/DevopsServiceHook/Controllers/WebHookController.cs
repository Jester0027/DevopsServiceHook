using DevopsServiceHook.Extensions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DevopsServiceHook.Controllers;

[ApiController]
[Route("devops/messages")]
public class WebHookController : ControllerBase
{
    private readonly IMediator _mediator;

    public WebHookController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public IActionResult ReceiveMessage([FromBody] AzureDevopsMessage.Models.AzureDevopsMessage message)
    {
        _mediator.Enqueue(message.ToCommand());
        return NoContent();
    }
}