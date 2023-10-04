using SignalRChat.DTOs;

namespace SignalRChat.Services
{
    public interface IChatService
    {
        Task Join(UserDTO user);
    }
}
