using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user_authentication_management.Database.Models;
using user_authentication_management.Database.Repository;

namespace user_authentication_management.ApplicationLogic.Validations
{
    class Authentication
    {

        public static void Register()
        {
            string name = GetName();

            string surname = GetSurname();

            string email = GetEmail();

            string password = GetPassword();



            if (!UserRepository.IsUserExistsByEmail(email))
            {
                User user = UserRepository.AddUSer(name, surname, email, password);
                Console.WriteLine("You successfully registered, now you can login with your new account!");
            }
            else
            {
                Console.WriteLine("User not added! Because, email already exists!");
            }
        }




        public static string GetName()
        {
            Console.Write("Please, enter user's name: ");
            string name = Console.ReadLine();

            while (!Validation.IsValidName(name))
            {
                Console.Write("Please, enter correct user name: ");
                name = Console.ReadLine();
            }
            return name;
        }

        public static string GetSurname()
        {
            Console.Write("Please, enter user's surname: ");
            string surname = Console.ReadLine();

            while (!Validation.IsValidSurname(surname))
            {
                Console.Write("Please, enter correct user surname: ");
                surname = Console.ReadLine();
            }
            return surname;

        }

        public static string GetEmail()
        {
            Console.Write("Please, enter user's email: ");
            string email = Console.ReadLine();

            while (!Validation.IsValidEmail(email))
            {
                Console.Write("Please, enter correct user email: ");
                email = Console.ReadLine();
            }
            return email;

        }

        public static string GetPassword()
        {
            Console.Write("Please, enter user's password: ");
            string password = Console.ReadLine();
            while (!Validation.IsValidPassword(password))
            {
                Console.Write("Please, enter correct user password: ");
                password = Console.ReadLine();
            }
            Console.Write("Please, enter password again: ");
            string confirmPassword = Console.ReadLine();
            while (!Validation.IsPasswordConfirm(password, confirmPassword))
            {
                Console.Write("Please, enter correct confirm password: ");
                confirmPassword = Console.ReadLine();
            }
            return password;

        }


        public static void Login()
        {
            Console.Write("Please, enter user email: ");
            string email = Console.ReadLine();

            Console.Write("Please, enter user password: ");
            string password = Console.ReadLine();


            if (email == "admin@gmail.com")
            {
                Console.WriteLine();
                Console.WriteLine("/showUser");
                Console.WriteLine();
                Console.Write("Enter Command: ");
                string command = Console.ReadLine();
                Console.WriteLine();
                if (command == "/showUser")
                {
                    foreach (User user in UserRepository.users)
                    {
                        Console.WriteLine(user.GetUserFullInfo());
                    }

                }

            }
            else if (UserRepository.IsUserExistByEmailAndPassword(email, password))
            {
                User user = UserRepository.GetUserByEmail(email);

                Console.WriteLine($"Welcome to your account {user.GetUserShortInfo()}!");
            }

            else
            {
                Console.WriteLine("User not found!");
            }



        }
    }
}