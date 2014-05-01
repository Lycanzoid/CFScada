<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logon.aspx.cs" Inherits="CyberFarminScada2.Logon" MasterPageFile="~/Template.Master" %>


<asp:Content ID="Content1" ContentPlaceHolderId="CPH1" runat="server">
    <!-- Content holder, holds individual content for this website. Inherits from Template.Master -->
        <h1>
        Login</h1>
    <p>
        Username:
        <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserNameTextBox" ErrorMessage="Please enter your username" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>

    <p>
        Password:
        <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="PasswordTextBox" ErrorMessage="Please enter your passsword" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:CheckBox ID="RememberMe" runat="server" Text="Remember Me" /> </p>
    <p>
        <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="Logon_Click" /> </p>
    <p>
        <asp:Label ID="InvalidCredentialsMessage" runat="server" ForeColor="Red" Text="Your username or password is invalid. Please try again."
            Visible="False"></asp:Label> </p>
</asp:Content>
