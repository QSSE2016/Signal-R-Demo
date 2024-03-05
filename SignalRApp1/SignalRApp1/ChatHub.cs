using Microsoft.AspNetCore.SignalR;

namespace SignalRApp1
{
    public sealed class ChatHub : Hub
    {
        // Called when Hub is connected
        public override async Task OnConnectedAsync()
        {
            // send a message to all clients (those who are connected to the hub).
            // The message here being to call the "ReceiveMessage" function that is hopefully defined on the client-side.
            await Clients.All.SendAsync("ReceiveMessage", $"{Context.ConnectionId} has joined");
        }
    }
}
