using DotNet8.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ApplicationController : ControllerBase
{
    private readonly IApplicationService _applicationService;
    private readonly INotificationService _notificationService;

    public ApplicationController(
        IApplicationService applicationService,
        INotificationService notificationService)
    {
        _applicationService = applicationService;
        _notificationService = notificationService;
    }

    [HttpPost("SendMessage")]
    public IActionResult SendMessage(string message)
    {
        var messageSent = _applicationService.SendMessage(
            _notificationService,
            message);

        return Ok(messageSent);
    }
}