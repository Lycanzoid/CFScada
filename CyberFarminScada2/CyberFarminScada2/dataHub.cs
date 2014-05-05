using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace CyberFarminScada2
{
    public class dataHub : Hub
    {
        private static readonly IHubContext context = GlobalHost.ConnectionManager.GetHubContext<dataHub>();
        //Method to broadcast temperature to all subscribers.
        internal static void ServerTemp(double temp)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<dataHub>();
            context.Clients.All.broadcastMessage(temp);
        }

        internal static void greenLight(string id, double greenLight) 
        {
            var client = context.Clients.Client(id).addMessage(greenLight);
            
            
        }
    }
}