using Microsoft.AspNetCore.Mvc;

namespace DevopsServiceHook.Controllers;

[ApiController]
[Route("devops/messages")]
public class WebHookController : ControllerBase
{
    [HttpPost]
    public IActionResult ReceiveMessage([FromBody] AzureDevopsMessage.Models.AzureDevopsMessage message)
    {
        return NoContent();
    }
}