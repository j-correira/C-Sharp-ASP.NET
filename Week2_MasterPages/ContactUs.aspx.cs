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
            lblformResults.Text += "<h3 style='color: green;'> First Name: " + fName.Text + "</h3><br>";
        }
        else
        {
            lblformFeedback.Text += "<h3 style='color: red;'> Oops... Forgot to enter First Name</h3><br>";
        }

        //validate middle name
        if (Validator.checkIfEmpty(mName.Text) == true)
        { 
            lblformResults.Text += "<h3 style='color: green;'> Middle Name: " + mName.Text + "</h3><br>";
        }    
        else
        {
            lblformFeedback.Text += "<h3 style='color: red;'> Oops... Forgot to enter Middle Name</h3><br>";
        }

        //validate last name
        if (Validator.checkIfEmpty(lName.Text) == true)
        { 
            lblformResults.Text += "<h3 style='color: green;'> Last Name: " + lName.Text + "</h3><br>";
        }
        else
        {
            lblformFeedback.Text += "<h3 style='color: red;'> Oops... Forgot to enter Last Name</h3><br>";
        }

        //validate phone number
        if (Validator.checkLength(phone.Text, 10) == true)
        { 
            lblformResults.Text += "<h3 style='color: green;'> Phone Number: " + phone.Text + "</h3><br>";
        }
        else
        {
            lblformFeedback.Text += "<h3 style='color: red;'> Oops... Invalid Phone Number (Must be 10 digits)</h3><br>";
        }

        //validate email address
        if (Validator.CheckEmail(email.Text) == true)
        {
            lblformResults.Text += "<h3 style='color: green;'> Email: " + email.Text + "</h3><br>";
        }
        else
        {
            lblformFeedback.Text += "<h3 style='color: red;'> Oops... Invalid Email Address</h3><br>";
        }
    }//close click function

}
