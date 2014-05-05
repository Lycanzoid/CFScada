using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CyberFarminScada2
{
    public partial class ScadaGreenhouses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tempSim sim = new tempSim();
            Thread thread = new Thread(new ThreadStart(sim.simulate));
            thread.Start();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("scadaTemperature.aspx", true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("scadaLights.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("scadaCo2.aspx");

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("scadaAir.aspx");
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("scadaFertalizer.aspx");
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("scadaWaterLevel.aspx");
        }
    }
}