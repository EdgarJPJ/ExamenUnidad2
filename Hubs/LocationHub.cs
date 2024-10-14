using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ExamenUnidad2.Hubs
{
    public class LocationHub : Hub
    {
        public async Task SendLocation(double latitude, double longitude)
        {
            await Clients.All.SendAsync("ReceiveLocation", latitude, longitude);
        }
    }
}
