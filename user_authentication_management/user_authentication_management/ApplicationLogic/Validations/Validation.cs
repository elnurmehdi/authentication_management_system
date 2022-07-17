using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace user_authentication_management.ApplicationLogic.Validations
{
    class Validation
    {
        public static bool IsValidName(string name)
        {
            string pattern = "(?=^.{3,30}$)([A-Z]+[a-z]+)";

            Regex regex = new Regex(pattern);

            if (regex.IsMatch(name))
            {
                return true;
            }
            Console.WriteLine("The name you entered is incorrect," +
                      " make sure the name contains only letters, " +
                       "the first letter is capitalized, and the length is greater than 3 and less than 30.");

            return false;
        }

        public static bool IsValidSurname(string surname)
        {
            string pattern = "(?=^.{3,30}$)([A-Z]+[a-z]+)";

            Regex regex = new Regex(pattern);

            if (regex.IsMatch(surname))
            {
                return true;
            }
            Console.WriteLine("The surname you entered is incorrect," +
                      " make sure the name contains only letters, " +
                       "the first letter is capitalized, and the length is greater than 3 and less than 30.");

            return false;

        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^([a-zA-Z0-9]{10,30})(@code\.edu\.az)$";

            Regex regex = new Regex(pattern);


            if (regex.IsMatch(email))
            {
                return true;
            }
            Console.WriteLine("Email format is not valid! Email contains @ charachter, length can be min 10 max 30, should end with code.edu.az.");
            return false;

        }


        public static bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(password))
            {
                return true;
            }
            Console.WriteLine("Entered format is not valid! Password must contain at least one uppercase letter," +
                              " one lowercase letter and a number, and the length cannot be less than 8.");
            return false;


        }



        public static bool IsPasswordConfirm(string password, string confirmPassword)
        {
            if (password == confirmPassword)
            {
                return true;
            }
            Console.WriteLine("Confirm password is not the same with password");
            return false;
        }









    }
}
