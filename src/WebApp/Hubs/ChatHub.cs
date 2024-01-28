using Microsoft.AspNetCore.SignalR;

namespace WebApp.Hubs;

public class ChatHub:Hub
{
    public async Task BroadcastMessage(string message)
    {
        await Clients.Others.SendAsync(message);
    }
}
