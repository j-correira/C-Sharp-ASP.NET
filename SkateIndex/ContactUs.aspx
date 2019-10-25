<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">

    <!------ bootstrap contact form ---------->
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
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
</style>

<h3>Contact us!</h3>
    <br />
<p><b>Email:</b> lotsa@spam.com
    <br />
    <b>Phone:</b> (123)123-1234
    <br />
    <b>Address:</b> 123 Main St.
</p>
        



</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="cphSideContent" Runat="Server">
    <h5 id="sidePara">Give us your info!</h5>
    <img id="sideImg" src="http://icons.iconarchive.com/icons/graphicloads/100-flat-2/256/email-icon.png" />
</asp:Content>

