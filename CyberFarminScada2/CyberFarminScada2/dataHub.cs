using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace CyberFarminScada2
{
    public class dataHub : Hub
    {

        //Method to broadcast temperature to all subscribers.
        internal static void ServerTemp(double temp)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<dataHub>();
            context.Clients.All.broadcastMessage(temp);
        }
    }
}