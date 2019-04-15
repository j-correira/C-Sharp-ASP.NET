using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_Controls : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

        if (Session["Login"] != null && Session["Login"].ToString() == "Success")
        {
            //All good, they are logged in

            //output name of user logging in
            greeting.Text = "<h3>Hello, " + Session["UserName"].ToString() + "</h3><br><br>";
        }
        else
        {
            //they have not logged in, redirect them to the login page
            Response.Redirect("default.aspx");
        }
    }


    protected void logout_click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}