using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace CyberFarminScada2
{
    public class redLightHub : Hub
    {
        internal static void redLight(double redLight_value)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<redLightHub>();
            context.Clients.All.broadcastMessage(redLight_value);
        }
    }
}