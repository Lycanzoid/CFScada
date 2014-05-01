using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using Microsoft.WindowsAzure;
using Microsoft.ServiceBus.Messaging;

namespace CyberFarminScada2
{
    public class tempSim
    {
        public void simulate()
        {
            string connectionString =
             CloudConfigurationManager.GetSetting("Microsoft.ServiceBus.ConnectionString");

            SubscriptionClient Client =
                        SubscriptionClient.CreateFromConnectionString(connectionString, "temptopic", "AllMessages");
            
            
            Client.Receive();

            
                 while (true)
                 {
                    BrokeredMessage  message = Client.Receive();
                    var value = Double.Parse(message.GetBody<string>());

                     dataHub.ServerTemp(value);

                     message.Complete();
                   }
                    
            
        }
    }
}