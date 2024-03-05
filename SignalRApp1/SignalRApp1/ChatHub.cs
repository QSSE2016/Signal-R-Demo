using Microsoft.AspNetCore.SignalR;

namespace SignalRApp1
{
    // Hub is stronly typed now
    public sealed class ChatHub : Hub<IChatClient>
    {
        public async override Task OnConnectedAsync()
        {
            // Keep in mind, this is triggered ONLY AFTER THE CONNECTION AND THE PROTOCOL ARE ESTABLISHED. Simply connecting won't do, you need to specify the protocol (e.g json)
            await Clients.All.ReceiveMessage($"{Context.ConnectionId} has joined");
        }

        public async Task SendMessage(string message)
        {
            await Clients.All.ReceiveMessage($"{Context.ConnectionId} says: {message}");
        }
    }
}
