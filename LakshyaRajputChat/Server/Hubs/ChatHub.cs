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

         public async Task WhenTyping(string user)
        {
            await Clients.Others.SendAsync("UserTyping", user);
        }

         public async Task ForAnonMsg(string message)
        {
            await Clients.All.SendAsync("ReceiveAnonMessage", message);
        }
    }
}