using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class dbTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Login"] != null && Session["Login"].ToString() == "Success")
        {
            //All good, they are logged in
        }
        else
        {
            //they have not logged in, redirect them to the login page
            Response.Redirect("default.aspx");
        }



    //if a person ID is passed on load........
        string strPer_ID = "";
        int intPer_ID = 0;

        //Does Per_ID Exist?
        if ((!IsPostBack) && Request.QueryString["Per_ID"] != null)
        {
            //If so...Gather Person's ID and Fill Form
            strPer_ID = Request.QueryString["Per_ID"].ToString();
            Person_ID_lbl.Text += strPer_ID;

            intPer_ID = Convert.ToInt32(strPer_ID);

            //Fill the "temp" person's info based on ID
            SkatePark temp = new SkatePark();
            SqlDataReader dr = temp.GetOnePark(intPer_ID);

            while (dr.Read())
            {
                parkNameTxt.Text = dr["ParkName"].ToString();
                cityTxt.Text = dr["City"].ToString();
                stateTxt.Text = dr["State"].ToString();
                zipTxt.Text = dr["Zip"].ToString();
                address1Txt.Text = dr["Street1"].ToString();
                address2Txt.Text = dr["Street2"].ToString();
                materialDD.SelectedItem.Value = dr["Material"].ToString();
                terrainDD.SelectedItem.Value = dr["Terrain"].ToString();
                //dateCreatedCal.SelectedDate = dr["DateCreated"].ToString();
                sketchynessDD.SelectedItem.Value = dr["Sketchy"].ToString();
                websiteTxt.Text = dr["Website"].ToString();
            }

        }
        else
        {
            //Do nothing....basic add page (empty)
        }



    }

    protected void logout_click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }

    protected void addContact_Click(object sender, EventArgs e)
    {
        //strResultTxt.Text += "Clicked <br>";
        strResultTxt.Text = "";

        SkatePark temp = new SkatePark();
        temp.ParkName = parkNameTxt.Text;
        temp.City = cityTxt.Text;
        temp.State = stateTxt.Text;
        temp.Zip = zipTxt.Text;
        temp.Street1 = address1Txt.Text;
        temp.Street2 = address2Txt.Text;
        temp.Material = materialDD.SelectedItem.Value;
        temp.Terrain = terrainDD.SelectedItem.Value;
        //temp.DateCreated = dateCreatedCal.SelectedDate;
        temp.Condition = conditionDD.SelectedItem.Value;
        temp.Sketchy = sketchynessDD.SelectedItem.Value;
        temp.Website = websiteTxt.Text;

        //temp.AddARecord();
        //temp.Feedback2 = strResultTxt.Text;
        //strResultTxt.Text += temp.Feedback1;
        strResultTxt.Text += temp.Feedback2;

        strResultTxt.Text += "<h5 style='color:green'> <u>Record Results:</u></h5>" + "<b>Park Name: </b>" + temp.ParkName + "<br><b>City: </b>" + temp.City + "<br><b>State: </b>" + temp.State + "<br><b>Zip: </b>" + temp.Zip + "<br><b>Address 1: </b>" + temp.Street1 + "<br><b>Address 2: </b>" + temp.Street2 + "<br><b>Material: </b>" + temp.Material + "<br><b>Terrain: </b>" + temp.Terrain + "<br><b>Date Created: </b>" + temp.DateCreated + "<br><b>Condition: </b>" + temp.Condition + "<br><b>Sketchyness: </b>" + temp.Sketchy + "<br><b>Website/Instagram: </b>" + temp.Website;

        //if no errors in validation...
        if (!temp.Feedback2.Contains("ERROR") || !temp.Feedback2.Contains("ERROR"))
        {
            temp.AddAPark();
        }

    }

    protected void deleteBTN_Click(object sender, EventArgs e)
    {
        //check.Text = "check update";

        SkatePark temp = new SkatePark();
        int Park_ID = Convert.ToInt32(Person_ID_lbl.Text);

        //strResultTxt.Text = temp.DeleteOnePerson(Person_ID);

        //  working
        //temp.DeleteOnePerson(Person_ID);

        strResultTxt.Text = Convert.ToString(temp.DeleteOnePark(Park_ID)) + " Record Successfully Deleted";
    }

    protected void updateBTN_Click(object sender, EventArgs e)
    {
        strResultTxt.Text = "";

        SkatePark temp = new SkatePark();
        temp.ParkName = parkNameTxt.Text;
        temp.City = cityTxt.Text;
        temp.State = stateTxt.Text;
        temp.Zip = zipTxt.Text;
        temp.Street1 = address1Txt.Text;
        temp.Street2 = address2Txt.Text;
        temp.Material = materialDD.SelectedItem.Value;
        temp.Terrain = terrainDD.SelectedItem.Value;
        //temp.DateCreated = dateCreatedCal.SelectedDate;
        temp.Condition = conditionDD.SelectedItem.Value;
        temp.Sketchy = sketchynessDD.SelectedItem.Value;
        temp.Website = websiteTxt.Text;

        //store id

        //TOO MANY LABELS!!! 
        //one has "Person ID:"
        temp.Park_ID = Convert.ToInt32(Person_ID_lbl.Text);

        //temp.AddARecord();
        //temp.Feedback2 = strResultTxt.Text;
        //strResultTxt.Text += temp.Feedback1;
        strResultTxt.Text += temp.Feedback2;

        check.Text = "check?";

        strResultTxt.Text = temp.UpdateRecord().ToString() + " Record Successfully Updated!";

    }







}

