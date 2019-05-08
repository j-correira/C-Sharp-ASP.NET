﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class ContactUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void testDB_Click(object sender, EventArgs e)
    {
        //create connection object
        SqlConnection Conn = new SqlConnection();

        //initialize properties
        //login info
        Conn.ConnectionString = @"Server=sql.neit.edu,4500;Database=SE245_JCorreira;User Id=SE245_jcorreira;Password=001248229;";

        string strSQL = "INSERT INTO Persons (Fname, Mname, Lname, City, State, Zip, Street1, Street2, Email, Phone, CellPhone, Facebook) VALUES (@Fname, @Mname, @Lname, @City, @State, @Zip, @Street1, @Street2, @Email, @Phone, @CellPhone, @Facebook)";

        //bark command
        SqlCommand comm = new SqlCommand();
        comm.CommandText = strSQL;
        comm.Connection = Conn;

        //try to connect to server
        try
        {
            //opens connection
            Conn.Open();

            //feedback if successfully connected
            //strResult += "SUCCESS! Connected to database" + Environment.NewLine;
            strResult.Text += "SUCCESS! Connected to database";

            //intRecs
            int intRecs = comm.ExecuteNonQuery();
            //strResult += $"SUCCESS! Inserted {intRecs} record(s)" + Environment.NewLine;

            //close connection
            Conn.Close();
        }
        catch
        {
            strResult.Text = "ERROR: Failed to connect to database";
        }
        finally
        {
            //runs regardless
            //not neccessary in c#
        }

        //return feedback string {strResult}
        //return strResult;
    }





    protected void submit_clickSQL(object sender, EventArgs e)
    {
        {
            lblformResults.Text = "";
            lblformFeedback.Text = "";

            //validate first name
            if (Validator.checkIfEmpty(fName.Text) == true)
            {
                lblformResults.Text += "<h5 style='color: green;'>• First Name: " + fName.Text + "</h5><br>";
            }
            else
            {
                lblformFeedback.Text += "<h5 style='color: red;'> • Forgot to enter First Name</h5><br>";
            }

            //validate middle name
            if (Validator.checkIfEmpty(mName.Text) == true)
            {
                lblformResults.Text += "<h5 style='color: green;'>• Middle Name: " + mName.Text + "</h5><br>";
            }
            else
            {
                lblformFeedback.Text += "<h5 style='color: red;'> • Forgot to enter Middle Name</h5><br>";
            }

            //validate last name
            if (Validator.checkIfEmpty(lName.Text) == true)
            {
                lblformResults.Text += "<h5 style='color: green;'>• Last Name: " + lName.Text + "</h5><br>";
            }
            else
            {
                lblformFeedback.Text += "<h5 style='color: red;'> • Forgot to enter Last Name</h5><br>";
            }

            //validate city
            if (Validator.checkIfEmpty(address1.Text) == true)
            {
                lblformResults.Text += "<h5 style='color: green;'>• City: " + city.Text + "</h5><br>";
            }
            else
            {
                lblformFeedback.Text += "<h5 style='color: red;'> • Forgot to enter City</h5><br>";
            }

            //validate state
            if (Validator.checkLength(state.Text, 2) == true)
            {
                lblformResults.Text += "<h5 style='color: green;'>• State: " + state.Text + "</h5><br>";
            }
            else
            {
                lblformFeedback.Text += "<h5 style='color: red;'> • Invalid State<br>&nbsp;&nbsp;(Must be 2 characters)</h5><br>";
            }

            //validate zip code
            if (Validator.checkLength(zip.Text, 5) == true)
            {
                lblformResults.Text += "<h5 style='color: green;'>• Zip Code: " + zip.Text + "</h5><br>";
            }
            else
            {
                lblformFeedback.Text += "<h5 style='color: red;'> • Invalid Zip Code<br>&nbsp;&nbsp;(Must be 5 digits)</h5><br>";
            }

            //validate address1
            if (Validator.checkIfEmpty(address1.Text) == true)
            {
                lblformResults.Text += "<h5 style='color: green;'>• Address 1: " + address1.Text + "</h5><br>";
            }
            else
            {
                lblformFeedback.Text += "<h5 style='color: red;'> • Forgot to enter Address 1</h5><br>";
            }

            //validate address2
            if (Validator.checkIfEmpty(address2.Text) == true)
            {
                lblformResults.Text += "<h5 style='color: green;'>• Address 2: " + address2.Text + "</h5><br>";
            }
            else
            {
                lblformFeedback.Text += "<h5 style='color: red;'> • Forgot to enter Address 2</h5><br>";
            }

            //validate email address
            if (Validator.CheckEmail(email.Text) == true)
            {
                lblformResults.Text += "<h5 style='color: green;'>• Email: " + email.Text + "</h5><br>";
            }
            else
            {
                lblformFeedback.Text += "<h5 style='color: red;'> • Invalid Email Address</h5><br>";
            }

            //validate phone number
            if (Validator.checkLength(phone.Text, 10) == true)
            {
                lblformResults.Text += "<h5 style='color: green;'>• Phone Number: " + phone.Text + "</h5><br>";
            }
            else
            {
                lblformFeedback.Text += "<h5 style='color: red;'> • Invalid Phone Number<br>&nbsp;&nbsp;(Must be 10 digits)</h5><br>";
            }

            //validate cell phone number
            if (Validator.checkLength(cellPhone.Text, 10) == true)
            {
                lblformResults.Text += "<h5 style='color: green;'>• Cell Phone Number:&nbsp;&nbsp;&nbsp;&nbsp;" + cellPhone.Text + "</h5><br>";
            }
            else
            {
                lblformFeedback.Text += "<h5 style='color: red;'> • Invalid Cell Phone Number (Must be 10 digits)</h5><br>";
            }

            //validate cell phone number
            if (Validator.checkIfEmpty(facebook.Text) == true)
            {
                lblformResults.Text += "<h5 style='color: green;'>• Facebook: " + facebook.Text + "</h5><br>";
            }
            else
            {
                lblformFeedback.Text += "<h5 style='color: red;'> • Forgot to enter Facebook</h5><br>";
            }


            //-------TESTING
            //add to DB w/o validation
            PersonV2 temp = new PersonV2();
            temp.Fname = fName.Text;
            temp.Mname = mName.Text;
            temp.Lname = lName.Text;
            temp.City = city.Text;
            temp.State = state.Text;
            temp.Zip = zip.Text;
            temp.Street1 = address1.Text;
            temp.Street2 = address2.Text;
            temp.Email = email.Text;
            temp.Phone = phone.Text;
            temp.CellPhone = cellPhone.Text;
            temp.Facebook = facebook.Text;

            temp.AddARecord();

            lblformFeedback.Text += temp.Fname + " " + temp.Mname + " " + temp.Lname;




        }//close click function

    }
}