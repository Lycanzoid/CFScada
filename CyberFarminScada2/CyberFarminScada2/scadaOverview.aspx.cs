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
        public static Queue<int> serverData { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            tempSim sim = new tempSim();
            Thread thread = new Thread(new ThreadStart(sim.simulate));
            thread.Start();

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            string message = "default";
            string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;


            SqlCeConnection connection =
            new SqlCeConnection(@"Data Source=|DataDirectory|\Database1.sdf");
            connection.Open();
            SqlCeCommand command = new SqlCeCommand("SELECT * FROM rabbit", connection);

            message = (string)command.ExecuteScalar();


            // receiverLabel.Text = message;
        }
    }
}