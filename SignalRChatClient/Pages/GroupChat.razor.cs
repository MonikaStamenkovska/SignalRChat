using Microsoft.AspNetCore.SignalR.Client;
using SignalRChatClient.Models;

namespace SignalRChatClient.Pages
{
    public partial class GroupChat : IDisposable
    {
        public List<UserDTO> users = new List<UserDTO>();
        public HubConnection connection { get; set; }
        public async void Dispose()
        {
            await connection.DisposeAsync();
        }

        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7056/chatHub")
                .Build();

            await connection.StartAsync();
            connection.On<UserDTO>("UserJoined", (user) =>
            {
                users.Add(user);
                InvokeAsync(() =>
                {
                    StateHasChanged();
                });
            });
        }
    }
}
