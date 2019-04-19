using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



    public class PersonV2 : Person
    {

        private string cellPhone;
        private string facebook;

        //holds error messages for inputs
        public string feedback = "";

        public string CellPhone
        {
            get
            {
                return cellPhone;
            }

            set
            {
                if (Validator.checkIfEmpty(value) == true)
                {
                    //check if length = 10
                    if (Validator.checkLength(value, 10) == true)
                    {
                        cellPhone = value;
                    }
                    else
                    {
                        feedback += "\nERROR! Invalid Cell Phone #";

                    }
                }
                else
                {
                    feedback += "\nERROR! Did not enter Cell Phone #";
                }
            }
        }

        public string Facebook
        {
            get
            {
                return facebook;
            }

            set
            {
                if (Validator.checkIfEmpty(value) == true)
                {
                    facebook = value;
                }
                else
                {
                    feedback += "\nERROR! Did not enter Facebook";
                }
            }
        }


        public string Feedback
        {
            get
            {
                return feedback;
            }
        }


        //sets all variables to "" so they cannot be null
        public PersonV2()
        {
            cellPhone = "";
            facebook = "";
            feedback = "";
        }




        public string AddARecord()
        {
            //inititalize 
            string strResult = "";

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

            comm.Parameters.AddWithValue("@Fname", Fname);
            comm.Parameters.AddWithValue("@Mname", Mname);
            comm.Parameters.AddWithValue("@Lname", Lname);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zip", Zip);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@CellPhone", CellPhone);
            comm.Parameters.AddWithValue("@Facebook", Facebook);




            //try to connect to server
            //try
            //{
                //opens connection
                Conn.Open();

        //feedback if successfully connected
        //strResult += "SUCCESS! Connected to database" + Environment.NewLine;
        //strResult.Text += "SUCCESS! Connected to database";

        //intRecs
        //int intRecs = comm.ExecuteNonQuery();
        comm.ExecuteNonQuery();
        //strResultTxt.Text += "SUCCESS! Inserted " + intRecs + " record(s) <br>";

        //close connection
        Conn.Close();
            //}
            //catch (Exception err)
            //{
                //strResult = "ERROR: Failed to connect to database " + err.Message;
            //}
            //finally
            //{
                //runs regardless
                //not neccessary in c#
            //}

            //return feedback string {strResult}
            return strResult;

        }//close AddARecord

        //searching



    }

 