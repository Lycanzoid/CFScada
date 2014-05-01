using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CyberFarminScada2
{
    public partial class scadaLights : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tempSim sim = new tempSim();
            Thread thread = new Thread(new ThreadStart(sim.simulate));
            thread.Start();
        }
    }
}