using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


public class SkatePark
    {

        public const string connstring = @"Server=sql.neit.edu,4500;Database=SE245_JCorreira;User Id=SE245_jcorreira;Password=001248229;";

        private string parkName;
        private string city;
        private string state;
        private string zip;
        private string street1;
        private string street2;
        private string material;
        private string terrain;
        private string dateCreated;
        private string condition;
        private string sketchy;
        private string website;

        public Int32 Park_ID = 0;

        //holds error messages for inputs
        public string feedback = "";

        public string ParkName
        {
            get
            {
                return parkName;
            }

            set
            {
                if (Validator.checkIfEmpty(value) == true)
                {
                    //check if length = 10
                    if (Validator.checkLength(value, 10) == true)
                    {
                        parkName = value;
                    }
                    else
                    {
                        feedback += "<p style='color: red;'>• <b>ERROR!</b> Invalid Cell Terrain #</p>";

                    }
                }
                else
                {
                    feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter Cell Terrain #</p>";
                }
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                if (Validator.checkIfEmpty(value) == true)
                {
                    city = value;
                }
                else
                {
                    //feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter city</p>";
                }
            }
        }

    public string State
    {
        get
        {
            return state;
        }

        set
        {
            if (Validator.checkIfEmpty(value) == true)
            {
                //check if length = 10
                if (Validator.checkLength(value, 2) == true)
                {
                    state = value;
                }
                else
                {
                    feedback += "<p style='color: red;'>• <b>ERROR!</b> Invalid Cell Terrain #</p>";

                }
            }
            else
            {
                //feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter Cell Terrain #</p>";
            }
        }
    }


    public string Zip
    {
        get
        {
            return zip;
        }

        set
        {
            if (Validator.checkIfEmpty(value) == true)
            {
                //check if length = 10
                if (Validator.checkLength(value, 5) == true)
                {
                    zip = value;
                }
                else
                {
                    feedback += "<p style='color: red;'>• <b>ERROR!</b> Invalid Cell Terrain #</p>";

                }
            }
            else
            {
                //feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter Cell Terrain #</p>";
            }
        }
    }


    public string Street1
    {
        get
        {
            return street1;
        }

        set
        {
            if (Validator.checkIfEmpty(value) == true)
            {
                //check if length = 10
                //if (Validator.checkLength(value, 10) == true)
                //{
                    street1 = value;
                //}
                //else
                //{
                    //feedback += "<p style='color: red;'>• <b>ERROR!</b> Invalid Cell Terrain #</p>";

                //}
            }
            else
            {
                //feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter Cell Terrain #</p>";
            }
        }
    }


    public string Street2
    {
        get
        {
            return street2;
        }

        set
        {
            if (Validator.checkIfEmpty(value) == true)
            {
                //check if length = 10
                //if (Validator.checkLength(value, 10) == true)
                //{
                street2 = value;
                //}
                //else
                //{
                //feedback += "<p style='color: red;'>• <b>ERROR!</b> Invalid Cell Terrain #</p>";

                //}
            }
            else
            {
                //feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter Cell Terrain #</p>";
            }
        }
    }


    public string Material
    {
        get
        {
            return material;
        }

        set
        {
            if (Validator.checkIfEmpty(value) == true)
            {
                //check if length = 10
                //if (Validator.checkLength(value, 10) == true)
                //{
                material = value;
                //}
                //else
                //{
                //feedback += "<p style='color: red;'>• <b>ERROR!</b> Invalid Cell Terrain #</p>";

                //}
            }
            else
            {
                //feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter Cell Terrain #</p>";
            }
        }
    }


    public string Terrain
    {
        get
        {
            return terrain;
        }

        set
        {
            if (Validator.checkIfEmpty(value) == true)
            {
                //check if length = 10
                //if (Validator.checkLength(value, 10) == true)
                //{
                terrain = value;
                //}
                //else
                //{
                //feedback += "<p style='color: red;'>• <b>ERROR!</b> Invalid Cell Terrain #</p>";

                //}
            }
            else
            {
                //feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter Cell Terrain #</p>";
            }
        }
    }


    public string DateCreated
    {
        get
        {
            return dateCreated;
        }

        set
        {
            if (Validator.checkIfEmpty(value) == true)
            {
                //check if length = 10
                //if (Validator.checkLength(value, 10) == true)
                //{
                dateCreated = value;
                //}
                //else
                //{
                //feedback += "<p style='color: red;'>• <b>ERROR!</b> Invalid Cell Terrain #</p>";

                //}
            }
            else
            {
                //feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter Cell Terrain #</p>";
            }
        }
    }


    public string Condition
    {
        get
        {
            return condition;
        }

        set
        {
            if (Validator.checkIfEmpty(value) == true)
            {
                //check if length = 10
                //if (Validator.checkLength(value, 10) == true)
                //{
                condition = value;
                //}
                //else
                //{
                //feedback += "<p style='color: red;'>• <b>ERROR!</b> Invalid Cell Terrain #</p>";

                //}
            }
            else
            {
                //feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter Cell Terrain #</p>";
            }
        }
    }


    public string Sketchy
    {
        get
        {
            return sketchy;
        }

        set
        {
            if (Validator.checkIfEmpty(value) == true)
            {
                //check if length = 10
                //if (Validator.checkLength(value, 10) == true)
                //{
                sketchy = value;
                //}
                //else
                //{
                //feedback += "<p style='color: red;'>• <b>ERROR!</b> Invalid Cell Terrain #</p>";

                //}
            }
            else
            {
                //feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter Cell Terrain #</p>";
            }
        }
    }


    public string Website
    {
        get
        {
            return website;
        }

        set
        {
            if (Validator.checkIfEmpty(value) == true)
            {
                //check if length = 10
                //if (Validator.checkLength(value, 10) == true)
                //{
                website = value;
                //}
                //else
                //{
                //feedback += "<p style='color: red;'>• <b>ERROR!</b> Invalid Cell Terrain #</p>";

                //}
            }
            else
            {
                //feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter Cell Terrain #</p>";
            }
        }
    }




    public string Feedback2
        {
            get
            {
                return feedback;
            }
        }


        //sets all variables to "" so they cannot be null
        public SkatePark()
        {
            parkName = "";
            city = "";
            state = "";
            zip = "";
            street1 = "";
            street2 = "";
            material = "";
            terrain = "";
            dateCreated = "";
            condition = "";
            sketchy = "";
            website = "";
            feedback = "";
        }




        public string AddAPark()
        {
            //inititalize 
            string strResult = "";

            //create connection object
            SqlConnection Conn = new SqlConnection();

            //initialize properties
            //login info
            Conn.ConnectionString = @"Server=sql.neit.edu,4500;Database=SE245_JCorreira;User Id=SE245_jcorreira;Password=001248229;";

            string strSQL = "INSERT INTO SkateParks (ParkName, City, State, Zip, Street1, Street2, Material, Terrain, DateCreated, Condition, Sketchy, Website) VALUES (@ParkName, @City, @State, @Zip, @Street1, @Street2, @Material, @Terrain, @DateCreated, @Condition, @Sketchy, @Website)";

            //bark command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = Conn;

            comm.Parameters.AddWithValue("@ParkName", ParkName);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zip", Zip);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@Material", Material);
            comm.Parameters.AddWithValue("@Terrain", Terrain);
            comm.Parameters.AddWithValue("@DateCreated", DateCreated);
            comm.Parameters.AddWithValue("@Condition", Condition);
            comm.Parameters.AddWithValue("@Sketchy", Sketchy);
            comm.Parameters.AddWithValue("@Website", Website);




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
        //strResultTxt.Text += "SUCCESS! Inserted " + intRecs + " record(s) ";

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


    public DataSet searchSkateParks(String ParkName, String State)
    {
        //create dataset
        DataSet ds = new DataSet();

        //create command
        SqlCommand comm = new SqlCommand();

        //write sql statement
        String strSQL = "SELECT Park_ID, ParkName, City, State FROM SkateParks WHERE 0=0";

        //if text boxes are filled in, search for LIKE names
        if (ParkName.Length > 0)
        {
            strSQL += " AND ParkName LIKE @ParkName";
            comm.Parameters.AddWithValue("@ParkName", "%" + ParkName + "%");
        }

        if (State.Length > 0)
        {
            strSQL += " AND State LIKE @State";
            comm.Parameters.AddWithValue("@State", "%" + State + "%");
        }

        //create & config DB tools
        SqlConnection conn = new SqlConnection();

        //who, what, where
        string strConn = @connstring;
        conn.ConnectionString = strConn;

        //info for command object
        comm.Connection = conn;     
        comm.CommandText = strSQL;  

        //data adapter
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = comm;    

        //retrieve data
        conn.Open();                
        da.Fill(ds, "SkateParks");     
        conn.Close();               

        //Return the data
        return ds;

    }// /searchSkateParks


    public SqlDataReader GetOnePark(int intPark_ID)
    {
        //create & init tools
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        //connection string
        string strConn = @connstring;

        //sql command
        string sqlString =
       "SELECT Park_ID, ParkName, City, State, Zip, Street1, Street2, Material, Terrain, DateCreated, Condition, Sketchy, Website FROM SkateParks WHERE Park_ID = @Park_ID;";

 /*
 string strSQL = "INSERT INTO SkateParks (ParkName, City, State, Zip, Street1, Street2, Material, Terrain, DateCreated, Condition, Sketchy) VALUES (@ParkName, @City, @State, @Zip, @Street1, @Street2, @Material, @Terrain, @DateCreated, @Condition, @Sketchy)";
         *          
         *          */

                //who, what, where
                conn.ConnectionString = strConn;

                //info for 1 person
                comm.Connection = conn;
                comm.CommandText = sqlString;
                comm.Parameters.AddWithValue("@Park_ID", intPark_ID);

                conn.Open();

                //return dataset
                return comm.ExecuteReader();   //Return the dataset to be used by others (the calling form)
            }// /GetOnePark



            public Int32 DeleteOnePark(int intPark_ID)
            {
                Int32 intRecords = 0;
                string strResult = "";

                //Create and Initialize the DB Tools we need
                SqlConnection conn = new SqlConnection();
                SqlCommand comm = new SqlCommand();

                //My Connection String
                string strConn = @connstring;

                //My SQL command string to pull up one person's data
                string sqlString =
               "DELETE FROM SkateParks WHERE Park_ID = @Park_ID;";

                //Tell the connection object the who, what, where, how
                conn.ConnectionString = strConn;

                //Give the command object info it needs
                comm.Connection = conn;
                comm.CommandText = sqlString;
                comm.Parameters.AddWithValue("@Park_ID", intPark_ID);


            try
            { 
                //Open the DataBase Connection and Yell our SQL Command
                conn.Open();

                //Run the deletion and store the number of records effected
                intRecords = comm.ExecuteNonQuery();
                strResult = intRecords.ToString() + " Record Deleted";
            }

            catch (Exception err)
            {
                strResult = "ERROR! " + err.Message;

            }

            finally
            { 
                //close the connection
                conn.Close();
            }

                return intRecords;   //Return # of records deleted
                //return strResult;

            }



            public Int32 UpdateRecord()
            {
                Int32 intRecords = 0;

                //sql statement
                string strSQL = "UPDATE SkateParks SET ParkName = @ParkName, City = @City, State = @State, Zip = @Zip, Street1 = @Street1, Street2 = @Street2, Material = @Material, Terrain = @Terrain, DateCreated = @DateCreated, Condition = @Condition, Sketchy = @Sketchy, Website = @Website WHERE Park_ID = @Park_ID;";

        /*  check against update statement
                   string strSQL = "INSERT INTO SkateParks (ParkName, City, State, Zip, Street1, Street2, Material, Terrain, DateCreated, Condition, Sketchy) VALUES (@ParkName, @City, @State, @Zip, @Street1, @Street2, @Material, @Terrain, @DateCreated, @Condition, @Sketchy)";
        */

        //connect to db
        SqlConnection conn = new SqlConnection();

        //Create the who, what where of the DB
        string strConn = @connstring;
        conn.ConnectionString = strConn;

        //bark command
        SqlCommand comm = new SqlCommand();
        comm.CommandText = strSQL;  
        comm.Connection = conn;

        //paramters (Has to be created in same sequence as they are used in SQL Statement)
        comm.Parameters.AddWithValue("@ParkName", ParkName);
        comm.Parameters.AddWithValue("@City", City);
        comm.Parameters.AddWithValue("@State", State);
        comm.Parameters.AddWithValue("@Zip", Zip);
        comm.Parameters.AddWithValue("@Street1", Street1);
        comm.Parameters.AddWithValue("@Street2", Street2);
        comm.Parameters.AddWithValue("@Material", Material);
        comm.Parameters.AddWithValue("@Terrain", Terrain);
        comm.Parameters.AddWithValue("@DateCreated", DateCreated);
        comm.Parameters.AddWithValue("@Condition", Condition);
        comm.Parameters.AddWithValue("@Sketchy", Sketchy);
        comm.Parameters.AddWithValue("@Website", Website);

        comm.Parameters.AddWithValue("@Park_ID", Park_ID);

       

        //try
        //{
            //open connection
            conn.Open();

            //run, store # rows effected
            intRecords = comm.ExecuteNonQuery();
        //}
        //catch (Exception err)
        //{
        //}
        //finally
        //{
            //close the connection
            conn.Close();
        //}

        return intRecords;

    }


}// close class

 