using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CyberFarminScada2
{
    public partial class ScadaGreenhouses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("scadaOverview.aspx", true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("scadaLights.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("#");
        }
    }
}