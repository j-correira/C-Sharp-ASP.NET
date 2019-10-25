using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submitLogin_click(object sender, EventArgs e)
    {

        //if successful login...
        if (username.Text == "Scott" && password.Text == "NEIT")
        { 
            
            Session["Login"] = "Success";
            Session["UserName"] = username.Text;

            //send user to controls page
            Response.Redirect("Controls.aspx");
        }

        else
        {
            lblFeedback.Text = "<h5>Oops.... Try again?</h5>";
            Session.Abandon();
        }
    }
}