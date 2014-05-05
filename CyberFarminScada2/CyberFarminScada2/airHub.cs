using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace CyberFarminScada2
{
    public class airHub : Hub
    {
        internal static void airHumidity(double air_value)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<airHub>();
            context.Clients.All.broadcastMessage(air_value);
        }
    }
}