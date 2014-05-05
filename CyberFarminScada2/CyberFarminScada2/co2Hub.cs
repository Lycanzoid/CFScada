using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace CyberFarminScada2
{
    public class co2Hub : Hub
    {
        internal static void co2level(double co2)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<co2Hub>();
            context.Clients.All.broadcastMessage(co2);
        }
    }
}