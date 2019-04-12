using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ContactUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submit_click(object sender, EventArgs e)
    {
        lblformResults.Text = "";
        lblformFeedback.Text = "";

        //validate first name
        if (Validator.checkIfEmpty(fName.Text) == true)
        {
            lblformResults.Text += "<h5 style='color: green;'> First Name: " + fName.Text + "</h5><br>";
        }
        else
        {
            lblformFeedback.Text += "<h5 style='color: red;'> Oops... Forgot to enter First Name</h5><br>";
        }

        //validate middle name
        if (Validator.checkIfEmpty(mName.Text) == true)
        { 
            lblformResults.Text += "<h5 style='color: green;'> Middle Name: " + mName.Text + "</h5><br>";
        }    
        else
        {
            lblformFeedback.Text += "<h5 style='color: red;'> Oops... Forgot to enter Middle Name</h5><br>";
        }

        //validate last name
        if (Validator.checkIfEmpty(lName.Text) == true)
        { 
            lblformResults.Text += "<h5 style='color: green;'> Last Name: " + lName.Text + "</h5><br>";
        }
        else
        {
            lblformFeedback.Text += "<h5 style='color: red;'> Oops... Forgot to enter Last Name</h5><br>";
        }

        //validate phone number
        if (Validator.checkLength(phone.Text, 10) == true)
        { 
            lblformResults.Text += "<h5 style='color: green;'> Phone Number: " + phone.Text + "</h5><br>";
        }
        else
        {
            lblformFeedback.Text += "<h5 style='color: red;'> Oops... Invalid Phone Number (Must be 10 digits)</h5><br>";
        }

        //validate email address
        if (Validator.CheckEmail(email.Text) == true)
        {
            lblformResults.Text += "<h5 style='color: green;'> Email: " + email.Text + "</h5><br>";
        }
        else
        {
            lblformFeedback.Text += "<h5 style='color: red;'> Oops... Invalid Email Address</h5><br>";
        }

        //validate address
        if (Validator.checkIfEmpty(address.Text) == true)
        {
            lblformResults.Text += "<h5 style='color: green;'> Address: " + email.Text + "</h5><br>";
        }
        else
        {
            lblformFeedback.Text += "<h5 style='color: red;'> Oops... Forgot to enter Address</h5><br>";
        }
    }//close click function

}
