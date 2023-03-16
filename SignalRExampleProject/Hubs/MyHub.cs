using Microsoft.AspNetCore.SignalR;

namespace SignalRExampleProject.Hubs
{
    public class MyHub : Hub
    {
        public static List<string> Names { get; set; } = new List<string>();

        public async Task SendNameAsync(string name)
        {
            await Clients.All.SendAsync("ReceiveName", name);
        }

        public async Task GetNamesAsync()
        {
            await Clients.All.SendAsync("ReceiveNames", Names);
        }
    }
}
