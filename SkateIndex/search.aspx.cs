using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void searchBTN_Click(object sender, EventArgs e)
    {
        SkatePark temp = new SkatePark();

        DataSet ds = temp.searchSkateParks(searchFname.Text, searchLname.Text);

        viewPersons.DataSource = ds;
        viewPersons.DataMember = ds.Tables[0].TableName;
        viewPersons.DataBind();
    }
}