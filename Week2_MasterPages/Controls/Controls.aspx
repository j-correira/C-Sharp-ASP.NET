<%@ Page Language="C#" MasterPageFile="~/Controls/ControlsMasterPage.master" AutoEventWireup="true" CodeFile="Controls.aspx.cs"  Inherits="Controls_Controls" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<main>
    <h4>The Control Panel</h4>
    <br />

    <asp:Label ID="greeting" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>


    <p>Buttons and clicky thingys will go here</p>
    <hr />
    <asp:Button ID="logout" class="btn btn-danger" runat="server" Text="Log Out" OnClick="logout_click"/>
    
    <br />
    <br />
    <a href="ContactMgr.aspx" class="btn btn-info" role="button">Go to Contact Manager</a>

</main>
</asp:Content>