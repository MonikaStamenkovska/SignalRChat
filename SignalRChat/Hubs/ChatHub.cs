using Microsoft.AspNetCore.SignalR;
using SignalRChat.DTOs;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub, IChatHub
    {
        private IHubContext<ChatHub> _context;

        public ChatHub(IHubContext<ChatHub> context)
        {
            _context = context;
        }

        public async Task UserJoined(UserDTO user)
        {
            await _context.Clients.All.SendAsync("UserJoined", user);
        }
    }
}
