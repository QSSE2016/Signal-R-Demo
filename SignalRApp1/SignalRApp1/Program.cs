using Microsoft.AspNetCore.SignalR;
using SignalRApp1;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// SignalR configuration
builder.Services.AddSignalR();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Setting up an endpoint "broadcast" for sending messages (POST requests hence MapPost) to clients from server.
app.MapPost("broadcast", async (string message, IHubContext<ChatHub, IChatClient> context) =>
{
    await context.Clients.All.ReceiveMessage(message);

    return Results.NoContent(); // status 204 = no content.
});

// specify route (in this chase "chat-hub") for my clients to connect to.
app.MapHub<ChatHub>("chat-hub");

app.Run();