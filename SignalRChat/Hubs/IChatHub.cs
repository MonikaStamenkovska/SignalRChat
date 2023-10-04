using SignalRChat.DTOs;

namespace SignalRChat.Hubs
{
    public interface IChatHub
    {
        Task UserJoined(UserDTO user);
    }
}
