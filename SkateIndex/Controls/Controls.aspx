<%@ Page Language="C#" MasterPageFile="~/Controls/ControlsMasterPage.master" AutoEventWireup="true" CodeFile="Controls.aspx.cs"  Inherits="Controls_Controls" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<main>
    <h2>The Control Panel</h2>
    <asp:Label ID="greetLbl" runat="server" Text="Label"></asp:Label>
    <p>Buttons and clicky thingys will go here</p>
    <a href="ContactMgr.aspx" class="btn btn-info">Go To Contact Manager</a>
    <br />
    <br />
    <a href="/search.aspx" class="btn btn-info">Go To Search</a>
    <hr />
    <br />
    <asp:Button ID="logout" class="btn btn-danger" runat="server" Text="Log Out" OnClick="logout_click"/>
    <br />
    <br />
    

</main>
</asp:Content>