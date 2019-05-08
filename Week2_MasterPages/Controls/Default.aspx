<%@ Page Title="" Language="C#" MasterPageFile="~/Controls/ControlsMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Controls_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <main>
        <div id="loginWrap">
            <div id="loginBox">
                <h3>Username:&nbsp;</h3>
                <asp:TextBox ID="username" value="Scott" runat="server"></asp:TextBox>
                <br />
                <br />
                <h3>Password:&nbsp;&nbsp;</h3>
                <asp:TextBox ID="password" TextMode="Password" value="" runat="server"></asp:TextBox>
                <br />
                <br />
                <div id="centerSubmit">
                    <asp:Button ID="submitLogin" runat="server" Text="Login" class="btn btn-primary" OnClick="submitLogin_click" />
                    <br />
                    <br />
                    <div id="centerFeedback">
                        <asp:Label ID="lblFeedback" runat="server" />
                    </div>
                </div>
            </div>
        </div><!-- /loginWrap -->
    </main>

</asp:Content>
 