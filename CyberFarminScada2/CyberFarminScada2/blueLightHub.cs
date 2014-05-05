using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;


namespace CyberFarminScada2
{
    public class blueLightHub : Hub
    {
        internal static void greenLight(double greenlight_value)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<blueLightHub>();
            context.Clients.All.broadcastMessage(greenlight_value);
        }
    }
}