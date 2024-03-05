namespace SignalRApp1
{
    // Represents the messages that are exposed to the client (from the hub)
    public interface IChatClient
    {
        Task ReceiveMessage(string message);
    }
}
