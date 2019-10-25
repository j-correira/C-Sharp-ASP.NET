<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dbTest.aspx.cs" Inherits="dbTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

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

    .contact-form{
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
    width:147px
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
}

#inputFields
{
    float: left;
    width:190px;
}
</style>


</head>
<body>







<!-- 

    <form id="form1" runat="server">
    <div id="inputFields">
        <h5>First Name:&nbsp;</h5>
        <asp:TextBox ID="fNameTxt" placeholder="First Name" value="Test" runat="server"></asp:TextBox>

        <h5>Middle Name:&nbsp;</h5>
        <asp:TextBox ID="mNameTxt" MaxLength="35" placeholder="Middle Name" runat="server"></asp:TextBox>
             
        <h5>Last Name:&nbsp;</h5>
                <asp:TextBox ID="lNameTxt" MaxLength="35" placeholder="Last Name" runat="server"></asp:TextBox>
         
         <h5>City:&nbsp;</h5>
                <asp:TextBox ID="cityTxt" MaxLength="35" placeholder="City" runat="server"></asp:TextBox>
          
        <h5>State:&nbsp;</h5>
                <asp:TextBox ID="stateTxt" MaxLength="2" placeholder="State" runat="server"></asp:TextBox>
             
        <h5>Zip Code:&nbsp;</h5>
                <asp:TextBox ID="zipTxt" MaxLength="5" placeholder="Zip Code" runat="server"></asp:TextBox>
             
        <h5>Address 1:&nbsp;</h5>
                <asp:TextBox ID="address1Txt" MaxLength="35" placeholder="1 Main St" runat="server"></asp:TextBox>
               
        <h5>Address 2:&nbsp;</h5>
                <asp:TextBox ID="address2Txt" MaxLength="35" placeholder="Apt. 3A" runat="server"></asp:TextBox>
          
        <h5>Email:&nbsp;</h5>
                <asp:TextBox ID="emailTxt" MaxLength="64" placeholder="emailer@email.com" runat="server"></asp:TextBox>
           
        <h5>Phone Number:&nbsp;</h5>
                <asp:TextBox ID="phoneTxt" MaxLength="13" placeholder="(321)321-4321" runat="server"></asp:TextBox>
           
        <h5>Cell Phone Number:&nbsp;</h5>
                <asp:TextBox ID="cellPhoneTxt" MaxLength="13" placeholder="(123)123-1234" runat="server"></asp:TextBox>
            
        <h5>Facebook:&nbsp;</h5>
                <asp:TextBox ID="facebookTxt" MaxLength="50" placeholder="facebook.com/dude" runat="server"></asp:TextBox>
         
       

    </div>

        <div id="buttonz">
            <asp:Button ID="Button2" runat="server" Text="Add Contact (Working!)"  />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Test DB Connection (Working)"  />
             <br />
            <br />
            <asp:Label ID="strResultTxt" runat="server" Text=""></asp:Label>
            <br />
        </div>

    </form>
</body>
</html>

-->