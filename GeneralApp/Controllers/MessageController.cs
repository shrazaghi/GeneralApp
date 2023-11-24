using GeneralApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace GeneralApp.Controllers;

[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{
    private IMessageNotifyService _messageNotifyService;
    public MessageController(IMessageNotifyService messageNotifyService)
    {
        _messageNotifyService = messageNotifyService;
    }

    [HttpPost(Name = "NewMessage")]
    public void PostNewMessage([FromRoute] int id, [FromBody] string message)
    {
        _messageNotifyService.Notify($"Id:{id}:{message}");
    }
}
