<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="search.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
    <style>
        #searchResults
        {
            margin-bottom: 75px;
            width:375px;
            float:right;
        }

        #searchBox
        {
            width:125px;
            float:left;
        }

        #SideContent
        {
            width: 192px;
            margin-right: 25px;
            display: block;
            border: 1px solid #6bb9f0;
            border-radius: 5px;
    }

    td
    {
        width:150px;
    }

    th
    {
        width:100px;
    }
    </style>



    <h1>Searching For People</h1>
    <hr />
    <br />

    <div id="searchBox">
    <h4>First Name: </h4>
    <asp:TextBox ID="searchFname" runat="server"></asp:TextBox>
    <br />
    <h4>Last Name: </h4>
    <asp:TextBox ID="searchLname" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="searchBTN" runat="server" Text="Search" OnClick="searchBTN_Click" />
    <br />
    <br />
    </div>

    <div id="searchResults">
    <h4>Search Results</h4>
    <br />
    <asp:GridView ID="viewPersons" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="FName" HeaderText="First Name"/>
            <asp:BoundField DataField="MName" HeaderText="Middle Name"/>
            <asp:BoundField DataField="LName" HeaderText="Last Name"/>
            <asp:HyperLinkField Text="Edit" DataNavigateUrlFormatString="Controls/ContactMgr.aspx?Per_ID={0}" DataNavigateUrlFields="Person_ID" />
        </Columns>
    </asp:GridView>
    </div>


</asp:Content>




<asp:Content ID="Content3" ContentPlaceHolderID="cphSideContent" Runat="Server">
    <img src="https://media2.giphy.com/media/UcGZJB4wtp0XK/giphy.gif" alt="magnify gif" height="190" width="190">
   
</asp:Content>

