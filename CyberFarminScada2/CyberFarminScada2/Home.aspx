<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CyberFarminScada2.Home"  MasterPageFile="~/Template.Master" %>
        
<asp:Content ID="Content1" ContentPlaceHolderId="CPH1" runat="server">
<!-- Content holder, holds individual content for this website. Inherits from Template.Master -->
<script src="http://ajax.microsoft.com/ajax/jquery/jquery-1.5.1.min.js" type="text/javascript"></script> 
<script src="Content/Highcharts-3.0.10/js/highcharts.js"></script>  

         
 
    <asp:Literal ID="ltrChart" runat="server"></asp:Literal>
   

           
 
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <br />
   

           
 
</asp:Content>
