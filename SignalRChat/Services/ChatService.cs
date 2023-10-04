using SignalRChat.DTOs;
using SignalRChat.Hubs;
using System;

namespace SignalRChat.Services
{
    public class ChatService : IChatService
    {
        private readonly IChatHub _chatHub;

        public ChatService(IChatHub chatHub)
        {
            _chatHub = chatHub;
        }
        public async Task Join(UserDTO user)
        {
            await _chatHub.UserJoined(user);
        }
    }
}
