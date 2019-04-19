<%@ Page Language="C#" MasterPageFile="~/Controls/ControlsMasterPage.master" AutoEventWireup="true" CodeFile="Controls.aspx.cs"  Inherits="Controls_Controls" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<main>
    <h2>The Control Panel</h2>
    <p>Buttons and clicky thingys will go here</p>
    <hr />
    <asp:Button ID="logout" class="btn btn-danger" runat="server" Text="Log Out" OnClick="logout_click"/>


</main>
</asp:Content>