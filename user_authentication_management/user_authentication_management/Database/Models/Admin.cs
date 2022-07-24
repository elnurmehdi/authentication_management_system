using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_authentication_management.Database.Models
{
    class Admin : User
    {

        public Admin(string name, string surname, string email, string password)
            :base(name, surname, email, password)
        {

        }


        public override string GetShortInfo()
        {
            return $"Hello admin, {Name}  {Surname}  {Email}";
        }



    }
}
