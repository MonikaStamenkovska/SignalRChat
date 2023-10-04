using Microsoft.AspNetCore.Mvc;
using SignalRChat.DTOs;
using SignalRChat.Services;

namespace SignalRChat.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;
        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpPost]
        public async Task Join(UserDTO user)
        {
            await _chatService.Join(user);
        }
    }
}
