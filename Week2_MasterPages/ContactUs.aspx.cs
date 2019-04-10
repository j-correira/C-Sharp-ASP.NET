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
        Session["firstName"] = fName.Text;

        //lblformResults.Text = Session["firstName"];
        lblformResults.Text = fName.Text + " " + mName.Text + " " + lName.Text;
    }
    
}
