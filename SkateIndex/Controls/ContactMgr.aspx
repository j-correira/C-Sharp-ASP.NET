<%@ Page Title="" Language="C#" MasterPageFile="~/Controls/ControlsMasterPage.master" AutoEventWireup="true" CodeFile="ContactMgr.aspx.cs" Inherits="dbTest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<html xmlns="http://www.w3.org/1999/xhtml">
    <title>Contact Manager</title>

<!------ bootstrap contact form ---------->
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" <id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

<style>

.jumbotron
{
    padding: 20px;
    margin-bottom: 2rem;
    background-color: #e9ecef;
    border-radius: 5px;
}

.contact-form
{
    background: #fff;
    margin-top: 13%;
    margin-bottom: 5%;
    width: 70%;
}
.contact-form .form-control{
    border-radius:1rem;
}
.contact-image{
    text-align: center;
}
.contact-image img{
    border-radius: 6rem;
    width: 11%;
    margin-top: -22%;
    transform: rotate(29deg);
}
.contact-form form{
    padding: 14%;
}
.contact-form form .row{
    margin-bottom: -7%;
}
.contact-form h3{
    margin-bottom: 8%;
    margin-top: -10%;
    text-align: left;
    color: #0062cc;
}
.contact-form .btnContact {
    width: 214%;
    border: none;
    border-radius: 1rem;
    padding: 1.5%;
    background: #007bff;
    font-weight: 600;
    color: #fff;
    cursor: pointer;
}
.btnContactSubmit
{
    width: 50%;
    border-radius: 1rem;
    padding: 1.5%;
    color: #fff;
    background-color: #0062cc;
    border: none;
    cursor: pointer;
}

#formLeft
{
    float:left;
}

#formRight
{
    float:left;
}

#sideImg
{
    height: 193px;
    padding: 15px;
}

#sidePara
{
    padding:15px;
}

#loginWrap
{
    float:left;
}

#centerFeedback
{
    border: 1px solid grey;
    border-radius:10px;
    padding:15px;
    padding: 15px;
    margin-bottom: 85px;
    width: 260px;
    float: right;
}

#centerSubmit
{
    margin-bottom: 16px;
}

h3
{
    margin:0;
}

h2
{
    display: inline;
}

#MainContent
{
    width: 80%;
    float: right;
    padding: 0px 0px 0px 35px;
    margin-bottom: 100px;
}

#cphMainContent_submitForm
{
    height: 53px;
    font-size: 26px;
    width: 260px;
    margin-left: -16px;
    margin-top: -16px;
    border-radius: 11px 11px 0px 0px;
}

input[type="text"]
{
    width:147px;
    margin-bottom: 25px;
}

#contactFormRight
{
    float:right;
    margin-left: 32px;
}

#contactFormLeft
{
    float:left;
}

#buttonz
{
    float:left;
    margin-left: 75px;
}

#inputFields
{
    float: left;
    width:367px;
    margin-left: 35px;
}

#centerAll
{
    margin:auto 0;
    padding:25px;
}

.btn-info
{
    color: #fff;
    background-color: #17a2b8;
    border-color: #17a2b8;
    width: 200px;
}

.btn-danger
{
    color: #fff;
    background-color: #dc3545;
    border-color: #dc3545;
    width: 200px;
}

.btn-primary
{
    color: #fff;
    background-color: #007bff;
    border-color: #007bff;
    width: 200px;
}

.btn-warning
{
    color: #FFF;
    background-color: #ffc107;
    border-color: #ffc107;
    width: 200px;
}


</style>


</head>
<body>

<div id="centerAll">

    <h2>Contact Manager</h2>
    <br />
    <asp:Label ID="Person_ID_lbl" runat="server" Text=""></asp:Label>
    <hr />
    <div id="inputFields">
    <div id="contactFormLeft">
        <h5>Skate Park Name:&nbsp;</h5>
        <asp:TextBox ID="parkNameTxt" placeholder="Hive" value="" runat="server"></asp:TextBox>

        <h5>City:&nbsp;</h5>
        <asp:TextBox ID="cityTxt" MaxLength="35" placeholder="New London" value="" runat="server"></asp:TextBox>
             
        <h5>State:&nbsp;</h5>
                <asp:TextBox ID="stateTxt" MaxLength="2" placeholder="CT" value=""  runat="server"></asp:TextBox>
         
         <h5>Zip:&nbsp;</h5>
                <asp:TextBox ID="zipTxt" MaxLength="5" placeholder="06320"  value="" runat="server"></asp:TextBox>
          
        <h5>Address 1:&nbsp;</h5>
                <asp:TextBox ID="address1Txt" MaxLength="40" placeholder="139 Shaw St"  value="" runat="server"></asp:TextBox>
        
        <h5>Address 2:&nbsp;</h5>
                <asp:TextBox ID="address2Txt" MaxLength="40" placeholder="Unit 3B"  value="" runat="server"></asp:TextBox>
        </div>
        <!-- /contactFormLeft -->
             
        <div id="contactFormRight">
        <h5>Park Material:&nbsp;</h5>
        <asp:DropDownList ID="materialDD" runat="server">
            <asp:ListItem Enabled="true" Text="Select Condition" Value="-1"></asp:ListItem>
            <asp:ListItem Text="Concrete" Value="concrete"></asp:ListItem>
            <asp:ListItem Text="Wood" Value="wood"></asp:ListItem>
            <asp:ListItem Text="Metal" Value="metal"></asp:ListItem>
            <asp:ListItem Text="Mixed" Value="mixed"></asp:ListItem>
        </asp:DropDownList>
               
        <h5>Terrain:&nbsp;</h5>
        <asp:DropDownList ID="terrainDD" runat="server">
            <asp:ListItem Enabled="true" Text="Select Condition" Value="-1"></asp:ListItem>
            <asp:ListItem Text="Transition" Value="transition"></asp:ListItem>
            <asp:ListItem Text="Street" Value="street"></asp:ListItem>
            <asp:ListItem Text="Mixed" Value="mixed"></asp:ListItem>
        </asp:DropDownList>
          
        <h5>Date Created:&nbsp;</h5>
            <asp:Calendar ID="dateCreatedCal" runat="server"></asp:Calendar>
           
        <h5>Park Condition:&nbsp;</h5>
        <asp:DropDownList ID="conditionDD" runat="server">
            <asp:ListItem Enabled="true" Text="Select Condition" Value="-1"></asp:ListItem>
            <asp:ListItem Text="Terrible" Value="1"></asp:ListItem>
            <asp:ListItem Text="Okay" Value="2"></asp:ListItem>
            <asp:ListItem Text="Decent" Value="3"></asp:ListItem>
            <asp:ListItem Text="Good" Value="4"></asp:ListItem>
            <asp:ListItem Text="Awesome" Value="5"></asp:ListItem>
        </asp:DropDownList>
           
        <h5>Sketchyness:&nbsp;</h5>
        <asp:DropDownList ID="sketchynessDD" runat="server">
            <asp:ListItem Enabled="true" Text="Select Condition" Value="-1"></asp:ListItem>
            <asp:ListItem Text="Not Sketchy" Value="1"></asp:ListItem>
            <asp:ListItem Text="Barely Sketchy" Value="2"></asp:ListItem>
            <asp:ListItem Text="Standard Sketchy" Value="3"></asp:ListItem>
            <asp:ListItem Text="Pretty Sketchy" Value="4"></asp:ListItem>
            <asp:ListItem Text="Super Sketchy" Value="5"></asp:ListItem>
        </asp:DropDownList>
            
        <h5>Website/Instagram:&nbsp;</h5>
                <asp:TextBox ID="websiteTxt" MaxLength="50" placeholder="hiveskateshop.com"  value="" runat="server"></asp:TextBox>
         </div>
        <!-- /contactFormRight -->
       

    </div>

        <div id="buttonz">
            <asp:Button ID="add" runat="server" Text="Add Contact To Database" class="btn btn-success" OnClick="addContact_Click" />
            <br />
            <br />
            <asp:Button ID="update" class="btn btn-warning" runat="server" Text="Update Record" OnClick="updateBTN_Click"/>
            <br />
            <br />
            <asp:Button ID="delete" class="btn btn-danger" runat="server" Text="Delete Record" OnClick="deleteBTN_Click"/>
            <br />
            <br />
            <asp:Label ID="strResultTxt" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <a href="/search.aspx" class="btn btn-info">Go To Search</a>
            <br />
            <br />
            <asp:Button ID="logOutContactMgr" class="btn btn-danger" runat="server" Text="• Log Out •" OnClick="logout_click"/>
            <br />
            <br />
            <asp:Label ID="check" runat="server" Text=""></asp:Label>
        </div><!-- /buttonz -->


    </div><!-- /centerAll -->


    </body>    
</html>

</asp:Content>

