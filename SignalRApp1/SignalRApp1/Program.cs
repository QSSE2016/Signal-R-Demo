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

// specify route (in this chase "chat-hub") for my clients to connect to.
app.MapHub<ChatHub>("chat-hub");

app.Run();