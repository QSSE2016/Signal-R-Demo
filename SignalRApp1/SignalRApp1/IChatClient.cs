namespace SignalRApp1
{
    // Represents the messages that are exposed to the client (from the hub)
    // Every single function here is essentially a shortcut for SendAsync, but they can take different parameters. Some may take strings, while others take whole objects...
    public interface IChatClient
    {
        Task ReceiveMessage(string message);
    }
}
