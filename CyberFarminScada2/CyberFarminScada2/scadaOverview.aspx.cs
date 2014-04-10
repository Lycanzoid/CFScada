using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Threading;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using System.Web.Services;
using System.Web.Script.Serialization;

namespace CyberFarminScada2.SCADA
{
    public partial class scadaOverview : System.Web.UI.Page
    {
               
        public static string serverVar { get; set; }
        public static Queue<int> serverData { get; set;}
        JavaScriptSerializer jss = new JavaScriptSerializer();
        
        loader load = new loader();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
            ThreadStart loader = new ThreadStart(load.makeLive);
            Thread thread = new Thread(loader);
            if (thread.IsAlive == false)
            {
               thread.Start();
            }
           
           
        }

        [WebMethod]
        public static double getData() {
            return 2.5;
        }
        [WebMethod]
        public static string getTemp()
        {
            return serverVar;
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string message = "default";
            string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;


            SqlCeConnection connection =
            new SqlCeConnection(@"Data Source=|DataDirectory|\Database1.sdf");
            connection.Open();
            SqlCeCommand command = new SqlCeCommand("SELECT * FROM rabbit",connection);

            message = (string)command.ExecuteScalar();

            
           // receiverLabel.Text = message;
        }
        class loader 
        {
            public void makeLive()
            {
                int count = 25;
                while (true)
               {
                    /**
                    JavaScriptSerializer jss = new JavaScriptSerializer();
                    string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
                    
                    SqlCeConnection connection =
                    new SqlCeConnection(@"Data Source=|DataDirectory|\Database1.sdf");
                    connection.Open();
                    SqlCeCommand command = new SqlCeCommand("SELECT * FROM temperature_readings", connection);

                    serverVar = (string)command.ExecuteScalar();
                     **/

                   count++;
                   
                 

                    Thread.Sleep(1000);
                }
            }
        }
  }
}