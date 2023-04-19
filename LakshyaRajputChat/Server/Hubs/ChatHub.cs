using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace LakshyaRajputChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}