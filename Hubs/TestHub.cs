using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace ragaio2.Hubs
{
    public class TestHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.Caller.SendAsync("ReceiveAnswer", message);
        }
    }
}