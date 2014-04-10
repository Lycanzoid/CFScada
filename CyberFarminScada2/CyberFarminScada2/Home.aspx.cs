using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CyberFarminScada2
{
    
    public partial class Home : System.Web.UI.Page
    {
        DotNet.Highcharts.Highcharts chart;
        protected void Page_Load(object sender, EventArgs e)
        {
            Domain dom = new Domain();

            chart = new DotNet.Highcharts.Highcharts("Readings")
        .SetXAxis(new XAxis
        {
            Categories = dom.getTempCategories()
        })
        .SetSeries(new Series
        {
            Data = new Data(dom.getTempData())
        }
        )
        .SetTitle(new Title { Text = "Temperature Readings" });

            ltrChart.Text = chart.ToHtmlString();
        }
        
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

    }
}