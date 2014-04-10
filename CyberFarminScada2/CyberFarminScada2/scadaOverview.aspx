<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="scadaOverview.aspx.cs" Inherits="CyberFarminScada2.SCADA.scadaOverview" MasterPageFile="~/Template.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderId="CPH1" runat="server">
    <script src="Content/jquery-1.5.1.min.js"></script>
    <script src="Content/Highcharts-3.0.10/js/highcharts.js"></script>  
    

<div id="container" style="min-width: 310px; height: 400px; margin: 0 auto">

    <!-- <asp:Literal ID="scadaChart" runat="server"></asp:Literal> -->

<script type="text/javascript">
    $(function () {
        $(document).ready(function () {
            Highcharts.setOptions({
                global: {
                    useUTC: false
                }
            });

            var chart;
            var graphDat;
            $('#container').highcharts({
                chart: {
                    type: 'spline',
                    animation: Highcharts.svg, // don't animate in old IE
                    marginRight: 10,
                    events: {
                        load: function () {

                            // set up the updating of the chart each second
                            var series = this.series[0];
                            
                            setInterval(function () {

                              
                                var x = (new Date()).getTime(), // current time


                                    y = Math.random()



                                series.addPoint([x, y], true, true);
                            }, 1000);
                        }
                    }
                },
                title: {
                    text: 'Temperature'
                },
                xAxis: {
                    type: 'datetime',
                    tickPixelInterval: 150
                },
                yAxis: {
                    title: {
                        text: 'Readings'
                    },
                    plotLines: [{
                        value: 0,
                        width: 1,
                        color: '#808080'
                    }]
                },
                tooltip: {
                    formatter: function () {
                        return '<b>' + this.series.name + '</b><br/>' +
                        Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', this.x) + '<br/>' +
                        Highcharts.numberFormat(this.y, 2);
                    }
                },
                legend: {
                    enabled: false
                },
                exporting: {
                    enabled: false
                },
                series: [{
                    name: 'Temperature',
                    data: (function () {
                        // generate an array of random data
                        var data = [],
                            time = (new Date()).getTime(),
                            i;

                        for (i = -19; i <= 0; i++) {
                            data.push({
                                x: time + i * 1000,
                                y: Math.random()
                            });
                        }
                        return data;
                    })()
                }]
            });
        });

    });
	</script>
</div>


</asp:Content>
