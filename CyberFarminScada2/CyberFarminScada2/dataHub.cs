using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace CyberFarminScada2
{
    public class dataHub : Hub
    {
        internal static void ServerClient(string message)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<dataHub>();
            context.Clients.All.broadcastMessage(message);
        }
        internal static void ServerTemp(double temp)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<dataHub>();
            context.Clients.All.broadcastMessage(temp);
        }
    }
}