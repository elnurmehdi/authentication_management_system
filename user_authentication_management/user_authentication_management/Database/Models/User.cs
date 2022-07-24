using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_authentication_management.Database.Models
{
    class User
    {
        private static int _idcounter = 1;
        public int Id { get; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime _registerTime;

        public User(string name, string surname, string email, string password)
        {
            Id = _idcounter;
            _idcounter++;
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            _registerTime = DateTime.Now;
        }


        public string GetUserFullInfo()
        {
            return $"Id: {Id} Name: {Name}  Surname: {Surname}  Email: {Email} Registiration date: {_registerTime} ";
        }


        public virtual string GetShortInfo()
        {
            return $"Hello user, {Name}  {Surname}  {Email}";
        }
    }
}

