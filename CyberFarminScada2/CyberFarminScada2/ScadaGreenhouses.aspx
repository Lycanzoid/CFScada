<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScadaGreenhouses.aspx.cs" Inherits="CyberFarminScada2.ScadaGreenhouses" MasterPageFile="~/Template.Master"  %>

<asp:Content ID="Content1" ContentPlaceHolderId="CPH1" runat="server">
    <div style="height:400px; width:820px;">

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
