using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Validator
    {
  

    //checks for empty input
    public static bool checkIfEmpty(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }
        /*
            else
            {
                lblformFeedback.Text = "Ooops, forgot to enter something!";
            }
        */
            return result;
        }//close checkIfEmpty


/*
        //check for int
        public static bool checkForInt(int temp)
        {
            int rewardsInt;
            Boolean result = int.TryParse(temp, out rewardsInt);

            if (result == false)
            {
                return false;
            }
            else
            {
                return true;
            }

            return result;
        }//close checkForInt
*/

        //check if date entered is a past date
        public static bool CheckIfPast(DateTime temp)
        {
            bool blnResult;

            if (temp <= DateTime.Now)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;

                Console.WriteLine("---------------------------------");
                Console.WriteLine("Ooops, that is not a Past date!");
                Console.WriteLine("---------------------------------\n");
            }

            return blnResult;
        }


        //checks length of input is longer than {minLen}
        public static bool checkLength(string temp, int minLen)
        {
            bool result = false;

            if (temp.Length >= minLen)
            {
                result = true;
            }
            else
            {
            /*
                Console.WriteLine("---------------------");
                Console.WriteLine("Ooops, invalid input!");
                Console.WriteLine("---------------------\n");
            */
            }

            return result;
        }

        //checks length of input is = {length}
        public static bool LengthEquals(string temp, int length)
        {
            bool result = false;

            if (temp.Length == length)
            {
                result = true;
            }
        /*
            else
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Ooops, invalid input!");
                Console.WriteLine("---------------------\n");
            }
        */
            return result;
        }

        public static bool CheckZip(string temp, int ZipLength = 5)
        {

            bool result = false;

            if (temp.Length == ZipLength)
            {
                result = true;
            }
        
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Ooops, invalid zip code input!");
                Console.WriteLine("------------------------------\n");
            }

            return result;
        }


        //check this.........
        public static bool CheckEmail(string temp)
        {
            bool result = true;

            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation + 1);
            int periodLocation = temp.LastIndexOf(".");

            if (temp.Length < 8)
            {
                result = false;
            }
            else if (atLocation < 2)
            {
                result = false;
            }
            else if (periodLocation + 2 > (temp.Length))
            {
                result = false;
            }

            return result;
        }

    }

