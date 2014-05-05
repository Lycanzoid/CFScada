using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace CyberFarminScada2
{
    public class fertalizerHub : Hub
    {
        internal static void fertalizer(double fert_value)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<fertalizerHub>();
            context.Clients.All.broadcastMessage(fert_value);
        }
    }
}