using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace CyberFarminScada2
{
    public class waterHub : Hub
    {
        internal static void water(double water_level)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<waterHub>();
            context.Clients.All.broadcastMessage(water_level);
        }
    }
}