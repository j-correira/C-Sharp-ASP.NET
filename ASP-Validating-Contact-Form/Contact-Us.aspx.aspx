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

 <div id="loginWrap">
            <div id="loginBox">

                <div id="contactFormLeft">
                <h5>First Name:&nbsp;</h5>
                <asp:TextBox ID="fName" placeholder="First Name" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="validateFName" MaxLength="35" runat="server" ControlToValidate="fName" ErrorMessage="<p style='color:red;'>‣ First Name is required</p>"/>
                <asp:RegularExpressionValidator ID="regexFName" runat="server" ErrorMessage="<p style='color:red;'>‣ Invalid First Name</p>" ControlToValidate="fName" ValidationExpression="^[A-Za-z]+$">
                </asp:RegularExpressionValidator>     

                <h5>Middle Name:&nbsp;</h5>
                <asp:TextBox ID="mName" MaxLength="35" placeholder="Middle Name" runat="server"></asp:TextBox>
                <br />
                <asp:RegularExpressionValidator ID="regexMName" runat="server" ErrorMessage="<p style='color:red;'>‣ Invalid Middle Name</p>" ControlToValidate="mName" ValidationExpression="^[A-Za-z]+$">
                </asp:RegularExpressionValidator>
                <br />
                <br />
                

                <h5>Last Name:&nbsp;</h5>
                <asp:TextBox ID="lName" MaxLength="35" placeholder="Last Name" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="validateLName" runat="server" ControlToValidate="lName" ErrorMessage="<p style='color:red;'>‣ Last Name is required</p>"/>
                <asp:RegularExpressionValidator ID="regexLName" runat="server" ErrorMessage="<p style='color:red;'>‣ Invalid Last Name</p>" ControlToValidate="lName" ValidationExpression="^[A-Za-z]+$">
                </asp:RegularExpressionValidator>

                <h5>City:&nbsp;</h5>
                <asp:TextBox ID="city" MaxLength="35" placeholder="City" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="validateCity" runat="server" ControlToValidate="city" ErrorMessage="<p style='color:red;'>‣ City Must is required</p>"/>

                <h5>State:&nbsp;</h5>
                <asp:TextBox ID="state" MaxLength="2" placeholder="State" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="validateState" runat="server" ControlToValidate="state" ErrorMessage="<p style='color:red;'>‣ State Must is required</p>"/>
                
                
                <h5>Zip Code:&nbsp;</h5>
                <asp:TextBox ID="zip" MaxLength="5" placeholder="Zip Code" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="validateZip" runat="server" ControlToValidate="zip" ErrorMessage="<p style='color:red;'>‣ Zip Code is required</p>"/>
                <asp:RegularExpressionValidator ID="regexZip" runat="server" ErrorMessage="<p style='color:red;'>‣ Zip Code must be 5 digits</p>" ControlToValidate="zip" ValidationExpression="\d{5}">
                </asp:RegularExpressionValidator>
                <br />
                <asp:CompareValidator ID="validateZipInt" runat="server" ErrorMessage="<p style='color:red;'>‣ Zip Code must be numeric</p>" ControlToValidate="zip" Operator="DataTypeCheck" Type="Integer"/>
                <br />
                </div>

                <div id="contactFormRight">
                <h5>Address 1:&nbsp;</h5>
                <asp:TextBox ID="address1" MaxLength="35" placeholder="1 Main St" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="validateAddress1" runat="server" ControlToValidate="address1" ErrorMessage="<p style='color:red;'>‣ Address 1 is required</p>"/>
                <asp:RegularExpressionValidator ID="regexAddress1" runat="server" ErrorMessage="<p style='color:red;'>‣ Invalid Address 1 format</p>" ControlToValidate="address1" ValidationExpression="[0-9a-zA-Z #,-]+">
                </asp:RegularExpressionValidator>

                    

                <h5>Address 2:&nbsp;</h5>
                <asp:TextBox ID="address2" MaxLength="35" placeholder="Apt. 3A" runat="server"></asp:TextBox>
                <br />
                <asp:RegularExpressionValidator ID="regexAddress2" runat="server" ErrorMessage="<p style='color:red;'>‣ Invalid Address 2 format</p>" ControlToValidate="address2" ValidationExpression="[0-9a-zA-Z #,-]+">
                </asp:RegularExpressionValidator>
                <br />
                <br />

                <h5>Email:&nbsp;</h5>
                <asp:TextBox ID="email" MaxLength="64" placeholder="emailer@email.com" runat="server"></asp:TextBox>

                <asp:RequiredFieldValidator ID="validateEmail" runat="server" ControlToValidate="email" ErrorMessage="<p style='color:red;'>‣ The Email is required</p>"/>
                <asp:RegularExpressionValidator ID="regexEmail" runat="server" ErrorMessage="<p style='color:red;'>‣ Invalid Email format</p>" ControlToValidate="email" ValidationExpression="[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+">
                </asp:RegularExpressionValidator>

                <h5>Phone Number:&nbsp;</h5>
                <asp:TextBox ID="phone" MaxLength="13" placeholder="(321)321-4321" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="validatePhone" runat="server" ErrorMessage="<p style='color:red;'>‣ Invalid Phone Number format</p>" ControlToValidate="phone" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">
                </asp:RegularExpressionValidator>
                <br />             
                <br />

                <h5>Cell Phone Number:&nbsp;</h5>
                <asp:TextBox ID="cellPhone" MaxLength="13" placeholder="(123)123-1234" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="validateCellPhone" runat="server" ControlToValidate="cellPhone" ErrorMessage="<p style='color:red;'>‣ Cell Phone is required</p>"/>
                <asp:RegularExpressionValidator ID="regexPhone" runat="server" ErrorMessage="<p style='color:red;'>‣ Invalid Cell Phone Number format</p>" ControlToValidate="cellPhone" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">
                </asp:RegularExpressionValidator>
                <br />

                <h5>Facebook:&nbsp;</h5>
                <asp:TextBox ID="facebook" MaxLength="50" placeholder="facebook.com/dude" runat="server"></asp:TextBox>
                <br />
                <br />   
                </div>                            
            </div>
        </div><!-- /loginWrap -->



                    <div id="centerFeedback">
                        <div id="centerSubmit">
                            <asp:Button ID="submitForm" runat="server" Text="Submit" class="btn btn-primary" OnClick="submit_click" />
                        </div>
                        <asp:Label ID="lblformResults" runat="server" />
                        <asp:Label ID="lblformFeedback" runat="server" />
                    </div>

        <div id="formResults"></div>

<!------ end bootstrap contact form ---------->

<!-- test DB Connection Button -->
        <asp:Label ID="strResult" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="testDB_Click" />



</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="cphSideContent" Runat="Server">
    <h5 id="sidePara">Give us your info!</h5>
    <img id="sideImg" src="http://icons.iconarchive.com/icons/graphicloads/100-flat-2/256/email-icon.png" />
</asp:Content>

