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

        //Broadcasts the BLUE light value to subscribers.
        internal static void serverLightsBlue(double blue)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<dataHub>();
            context.Clients.All.broadcastMessage(blue);
        }
        //Broadcasts the RED light value to all subscribers.
        internal static void serverLightsRed(double blue)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<dataHub>();
            context.Clients.All.broadcastMessage(blue);
        }
    }
}