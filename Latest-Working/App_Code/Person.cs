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
                    feedback += "\nERROR! Did not enter a value for First Name" + Environment.NewLine;
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
                    feedback += "\nERROR! Did not enter a value for Middle Name" + Environment.NewLine;
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
                    feedback += "\nERROR! Did not enter a value for Last Name" + Environment.NewLine;
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
                    feedback += "\nERROR! Did not enter a value for Street 1" + Environment.NewLine;
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
                    feedback += "\nERROR! Did not enter a value for Street 2" + Environment.NewLine;
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
                    feedback += "\nERROR! Did not enter a value for City" + Environment.NewLine;
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
                        feedback += "\nERROR! Invalid State";
                    }
                }//close checkIfEmpty
                else
                {
                    feedback += "\nERROR! Did not enter State";
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
                        feedback += "\nERROR! Invalid Zip Code";
                    }
                }//close checkIfEmpty
                else
                {
                    feedback += "\nERROR! Did not enter Zip Code";
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
                        feedback += "\nERROR! Invalid Email";
                    }
                }//close checkIfEmpty
                else
                {
                    feedback += "\nERROR! Did not enter Email";
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
                        feedback += "\nERROR! Invalid Phone #";
                    }
                }
                else
                {
                    feedback += "\nERROR! Did not enter Phone #";
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

