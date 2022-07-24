using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user_authentication_management.Database.Models;

namespace user_authentication_management.Database.Repository
{
    class UserRepository
    {
        public static List<User> users { get; set; } = new List<User>()
        {
            new Admin("Super", "Admin", "admin@gmail.com","123321")
        };



        public static User AddUSer(string name, string surname, string email, string password)
        {
            User user = new User(name, surname, email, password);

            users.Add(user);
            return user;
        }


        public static User GetUserByEmail(string email)
        {
            foreach (User user in users)
            {
                if (email == user.Email)
                {
                    return user;
                }
            }
            return null;
        }


        public static bool IsUserExistsByEmail(string email)
        {
            foreach (User user in users)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }

            return false;
        }



        public static bool IsUserExistByEmailAndPassword(string email, string password)
        {


            foreach (User user in users)
            {
                if (email == user.Email && password == user.Password)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
