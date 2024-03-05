using Microsoft.AspNetCore.SignalR;

namespace SignalRApp1
{
    public sealed class ChatHub : Hub
    {
        public async override Task OnConnectedAsync()
        {
            // send a message to all clients (those who are connected to the hub).
            // The message here being to call the "ReceiveMessage" function that is hopefully defined on the client-side.
            // Keep in mind, this is triggered ONLY AFTER THE CONNECTION AND THE PROTOCOL ARE ESTABLISHED. Simply connecting won't do, you need to specify the protocol (e.g json)
            await Clients.All.SendAsync("ReceiveMessage", $"{Context.ConnectionId} has joined");
        }

        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", $"{Context.ConnectionId} says: {message}");
        }
    }
}
