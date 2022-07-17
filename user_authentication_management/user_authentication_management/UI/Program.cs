using System;
using user_authentication_management.ApplicationLogic.Validations;

namespace user_authentication_management
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("/register");
            Console.WriteLine("/login");
            Console.WriteLine("/exit");



            while (true)
            {


                Console.WriteLine();
                Console.WriteLine("Please, enter one of shown commands:");
                string command = Console.ReadLine();

                if (command == "/register")
                {
                    Authentication.Register();
                }
                else if (command == "/login")
                {
                    Authentication.Login();

                }
                else if (command == "/exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Command not found!");
                }
            }
        }
    }
}
