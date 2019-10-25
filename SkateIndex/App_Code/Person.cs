using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Person
    {

        private string fName;
        private string mName;
        private string lName;
        private string street1;
        private string street2;
        private string city;
        private string state;
        private string zip;
        private string email;
        private string phone;
        public int personID;

        //holds error messages for inputs
        private string feedback;

        public string Fname
        {
            get
            {
                return fName;
            }

            set
            {
                if (Validator.checkIfEmpty(value) == true)
                {
                    fName = value;
                }
                else
                {
                    feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter a value for First Name</p>";
                }
            }
        }

        public string Mname
        {
            get
            {
                return mName;
            }

            set
            {
                if (Validator.checkIfEmpty(value) == true)
                {
                    mName = value;
                }
                else
                {
                    feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter a value for Middle Name</p>";
                }
            }
        }

        public string Lname
        {
            get
            {
                return lName;
            }

            set
            {
                if (Validator.checkIfEmpty(value) == true)
                {
                    lName = value;
                }
                else
                {
                    feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter a value for Last Name</p>";
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
                    street1 = value;
                }
                else
                {
                    feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter a value for Street 1</p>";
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
                    street2 = value;
                }
                else
                {
                    feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter a value for Street 2</p>";
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
                    feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter a value for City</p>";
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
                    if (Validator.LengthEquals(value, 2) == true)
                    {
                        state = value;
                    }
                    else
                    {
                        feedback += "<p style='color: red;'>• <b>ERROR!</b> Invalid State</p>";
                    }
                }//close checkIfEmpty
                else
                {
                    feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter State</p>";
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
                //check if email field is empty
                if (Validator.checkIfEmpty(value) == true)
                {
                    if (Validator.CheckZip(value) == true)
                    {
                        zip = value;
                    }
                    else
                    {
                        feedback += "<p style='color: red;'>• <b>ERROR!</b> Invalid Zip Code</p>";
                    }
                }//close checkIfEmpty
                else
                {
                    feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter Zip Code</p>";
                }
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                //check if email field is empty
                if (Validator.checkIfEmpty(value) == true)
                {

                    //check if valid email format
                    if (Validator.CheckEmail(value) == true)
                    {
                        email = value;
                    }
                    else
                    {
                        feedback += "<p style='color: red;'>• <b>ERROR!</b> Invalid Email</p>";
                    }
                }//close checkIfEmpty
                else
                {
                    feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter Email</p>";
                }
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                if (Validator.checkIfEmpty(value) == true)
                {
                    //check if length = 10
                    if (Validator.checkLength(value, 10) == true)
                    {
                        phone = value;
                    }
                    else
                    {
                        feedback += "<p style='color: red;'>• <b>ERROR!</b> Invalid Phone #</p>";
                    }
                }
                else
                {
                    feedback += "<p style='color: red;'>• <b>ERROR!</b> Did not enter Phone #</p>";
                }
            }
        }

        public string Feedback1
        {
            get
            {
                return feedback;
            }
        }

        public Int32 PersonID
        {
            get
            {
                return personID;
            }
        }

        //sets all variables to "" so they cannot be null      
        public Person()
        {
            fName = "";
            mName = "";
            lName = "";
            street1 = "";
            street2 = "";
            city = "";
            state = "";
            zip = "";
            phone = "";
            feedback = "";
            //personID = "";
        }
        

    }

