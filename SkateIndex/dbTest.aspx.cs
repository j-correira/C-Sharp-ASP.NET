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

    }

    /*
    protected void addContact_Click(object sender, EventArgs e)
    {
        strResultTxt.Text += "Clicked <br>";

        SkatePark temp = new SkatePark();
        temp.Fname = fNameTxt.Text;
        temp.Mname = mNameTxt.Text;
        temp.Lname = lNameTxt.Text;
        temp.City = cityTxt.Text;
        temp.State = stateTxt.Text;
        temp.Zip = zipTxt.Text;
        temp.Street1 = address1Txt.Text;
        temp.Street2 = address2Txt.Text;
        temp.Email = emailTxt.Text;
        temp.Phone = phoneTxt.Text;
        temp.CellPhone = cellPhoneTxt.Text;
        temp.Facebook = facebookTxt.Text;

        temp.AddARecord();

        //strResult.Text += "Added: " temp.Fname + " " + "<br>";
        strResultTxt.Text += "Added: " + temp.Fname + " " + temp.Lname + "<br>";
    }

    */

    //WORKING
    protected void testDB_Click(object sender, EventArgs e)
    {
        //inititalize 

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

/*
comm.Parameters.AddWithValue("@Fname", fNameTxt.Text);
comm.Parameters.AddWithValue("@Mname", mNameTxt.Text);
comm.Parameters.AddWithValue("@Lname", lNameTxt.Text);
comm.Parameters.AddWithValue("@City", cityTxt.Text);
comm.Parameters.AddWithValue("@State", stateTxt.Text);
comm.Parameters.AddWithValue("@Zip", zipTxt.Text);
comm.Parameters.AddWithValue("@Street1", address1Txt.Text);
comm.Parameters.AddWithValue("@Street2", address2Txt.Text);
comm.Parameters.AddWithValue("@Email", emailTxt.Text);
comm.Parameters.AddWithValue("@Phone", phoneTxt.Text);
comm.Parameters.AddWithValue("@CellPhone", cellPhoneTxt.Text);
comm.Parameters.AddWithValue("@Facebook", facebookTxt.Text);
*/

        //try to connect to server
        try
        {
            //opens connection
            Conn.Open();

            //feedback if successfully connected
            strResultTxt.Text += "SUCCESS! Connected to database <br><br>";

            //intRecs
            comm.ExecuteNonQuery();
            //strResultTxt.Text += "SUCCESS! Inserted " + intRecs + " record(s) <br>";

            //close connection
            Conn.Close();
            //strResult.Text += "Added: " + fName.Text;
        }
        catch
        {
            strResultTxt.Text += "ERROR: Failed to connect to database <br>";
        }
        finally
        {
            //runs regardless
            //not neccessary in c#
        }
    }//close AddARecord

}

