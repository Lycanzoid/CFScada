﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="scadaAir.aspx.cs" Inherits="CyberFarminScada2.scadaAir" MasterPageFile="~/Template.Master" %>

<asp:Content ContentPlaceHolderID="CPH1" runat="server">
    <script src="Content/jquery-1.5.1.min.js"></script>
    <script src="Content/Highcharts-3.0.10/js/highcharts.js"></script>  
        <!--Reference the SignalR library. -->
    <script src="Scripts/jquery.signalR-2.0.3.min.js"></script>
    <!--Reference the autogenerated SignalR hub script. -->
    <script src="signalr/hubs"></script>

    <div id="container" style="min-width: 310px; height: 400px; margin: 0 auto; max-width:820px;">
    
      <script type="text/javascript">
      $(function () {
          $(document).ready(function () {
              Highcharts.setOptions({
                  global: {
                      useUTC: false
                  }
              });
              var data = $.connection.airHub;


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

                              data.client.broadcastMessage = function (air_val) {


                                  var x = (new Date()).getTime(), // current time


                                      y = parseFloat(air_val);



                                  series.addPoint([x, y], true, true);
                              };
                              $.connection.hub.start().done(function () {


                              });


                          }
                      }
                  },
                  title: {
                      text: 'Air Humidity (%)'
                  },
                  xAxis: {
                      type: 'datetime',
                      tickPixelInterval: 150
                  },
                  yAxis: {

                      title: {
                          text: ' Air Humidity '
                      },
                      plotLines: [{
                          value: 0,
                          width: 1,
                          color: '#808080',

                      }]
                  },
                  tooltip: {

                      formatter: function () {
                          return '<b>' + this.series.name + '</b><br/>' +
                          Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', this.x) + '<br/>' +
                          Highcharts.numberFormat(this.y, 2) + ' %';
                      }
                  },
                  legend: {
                      enabled: false
                  },
                  exporting: {
                      enabled: false
                  },
                  series: [{

                      floating: true,
                      name: 'Air Humidity',
                      data: (function () {
                          // generate an array of random data
                          var data = [],
                              time = (new Date()).getTime(),
                              i;

                          for (i = -19; i <= 0; i++) {
                              data.push({
                                  x: time + i * 1000,
                                  y: 0
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


