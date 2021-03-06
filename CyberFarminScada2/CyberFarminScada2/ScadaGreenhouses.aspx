﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScadaGreenhouses.aspx.cs" Inherits="CyberFarminScada2.ScadaGreenhouses" MasterPageFile="~/Template.Master"  %>

<asp:Content ID="Content1" ContentPlaceHolderId="CPH1" runat="server">

    <script src="Content/jquery-1.5.1.min.js"></script>
    <script src="Content/Highcharts-3.0.10/js/highcharts.js"></script>  
        <!--Reference the SignalR library. -->
    <script src="Scripts/jquery.signalR-2.0.3.min.js"></script>
    <!--Reference the autogenerated SignalR hub script. -->
    <script src="signalr/hubs"></script>
    
    <!-- Script for Temp-->
    <script type="text/javascript">
        <!-- Declaring multiple real-time connection to SignalR Hubs. -->
        var tempData = $.connection.dataHub;

       //Readying all connection to stream live data to javascript textboxes, to show all data.
        $(function() {
            $(document).ready(function () {
                tempData.client.broadcastMessage = function (temp) {
                    $("#tempBox").val(temp + " (℃)");
                };
                $.connection.hub.start().done(function () {
                });
            })
        })
    </script>
    <!-- Scipt for Co2-->
    <script type="text/javascript">
        <!-- Declaring multiple real-time connection to SignalR Hubs. -->
        var co2Data = $.connection.co2Hub;

    //Readying connection to stream live data to javascript textboxes, to show all data.
    $(function () {
        $(document).ready(function () {
            co2Data.client.broadcastMessage = function (co2) {
                $("#co2Box").val(co2 +" ppm");
            };
            $.connection.hub.start().done(function () {
            });
        })
    })
    </script>
    
    <!-- Script to load Air Value into Javascript textbox-->
    <script type="text/javascript">
        <!-- Declaring multiple real-time connection to SignalR Hubs. -->
        var airData = $.connection.airHub;

    //Readying connection to stream live data to javascript textboxes, to show all data.
    $(function () {
        $(document).ready(function () {
            airData.client.broadcastMessage = function (air) {
                $("#airBox").val(air + "%");
            };
            $.connection.hub.start().done(function () {
            });
        })
    })
    </script>

        <!-- Script to load water Value into Javascript textbox-->
    <script type="text/javascript">
        <!-- Declaring multiple real-time connection to SignalR Hubs. -->
    var waterData = $.connection.waterHub;

    //Readying connection to stream live data to javascript textboxes, to show all data.
    $(function () {
        $(document).ready(function () {
            waterData.client.broadcastMessage = function (water) {
                $("#waterBox").val(water + "%");
            };
            $.connection.hub.start().done(function () {
            });
        })
    })
    </script>
    <!-- Script to load fertalize percentage -->
    <script type="text/javascript">
        <!-- Declaring multiple real-time connection to SignalR Hubs. -->
    var fertData = $.connection.fertalizerHub;

    //Readying connection to stream live data to javascript textboxes, to show all data.
    $(function () {
        $(document).ready(function () {
            fertData.client.broadcastMessage = function (fert) {
                $("#fertBox").val(fert + "%");
            };
            $.connection.hub.start().done(function () {
            });
        })
    })
    </script>
    <!-- Script to load green light data -->
    <script type="text/javascript">
        <!-- Declaring multiple real-time connection to SignalR Hubs. -->
    var greenData = $.connection.blueLightHub;

    //Readying connection to stream live data to javascript textboxes, to show all data.
    $(function () {
        $(document).ready(function () {
            greenData.client.broadcastMessage = function (green) {
                $("#blueBox").val(green + "%");
            };
            $.connection.hub.start().done(function () {
            });
        })
    })
    </script>
        <!-- Script to load red light data -->
    <script type="text/javascript">
        <!-- Declaring multiple real-time connection to SignalR Hubs. -->
    var redData = $.connection.redLightHub;

    //Readying connection to stream live data to javascript textboxes, to show all data.
    $(function () {
        $(document).ready(function () {
            redData.client.broadcastMessage = function (red) {
                $("#redBox").val(red + "%");
            };
            $.connection.hub.start().done(function () {
            });
        })
    })
    </script>


    <div style="height:400px;">

        <ul id="Scada">
            <li>Temperature</li>
            <li><input type="text" id="tempBox" name="tempBox"/></li>
            <li>Co2 Level</li>
            <li><input type="text" id="co2Box" name="co2Box"/></li>
            <li>Air Humidity</li>
            <li><input type="text" id="airBox" name="airBox" /></li>
            <li>Water Level</li>
            <li><input type="text" id="waterBox" name="waterBox"/></li>
            <li>Fertalize level</li>
            <li><input type="text" id="fertBox" name="fertBox"/></li>
            <li>Lights</li>
            <li>
                <ul class="ScadaSec">
                    <li>
                        <ul class="ScadaThird">
                            <li>Red</li>
                            <li><input type="text" id="redBox" name="redBox"/></li>
                        </ul>
                    </li>
                    <li>
                        <ul class="ScadaThird">
                            <li>Blue</li>
                            <li><input type="text" id="blueBox" name="blueBox"/></li>
                        </ul>
                    </li>
                </ul>
            </li>
        </ul>
        
    </div>
   
    <div id="buttonContainer">
     <ul class="listHolder">
         <li>
             <ul>
                <li>
                    <asp:Button ID="tempButton" runat="server" Text="Temperature" OnClick="Button1_Click" Height="70px" Width="143px" />
                </li>
                <li>
                    <asp:Button ID="lightButton" runat="server" Text="Lights" Height="70px" Width="143px" OnClick="Button2_Click" />
                </li>
                <li>
                    <asp:Button ID="Co2Button" runat="server" Text="Co2 Level" Height="70px" Width="143px" OnClick="Button3_Click" />
                </li>
            </ul>
         </li>
         <li>
              <ul>
                <li>
                    <asp:Button ID="airButton" runat="server" Text="Air Humidity" Height="70px" Width="143px" OnClick="Button4_Click" />
                </li>
                <li>
                    <asp:Button ID="FertButton" runat="server" Text="Fertalizing" Height="70px" Width="143px" OnClick="Button5_Click" />
                </li>
                <li>
                    <asp:Button ID="waterLevel" runat="server" Text="Water Level" Height="70px" Width="143px" OnClick="Button6_Click" />
                </li>
            </ul>
        </li>
     </ul>
    
   
</div>
    </asp:Content>
