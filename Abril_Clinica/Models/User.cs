//using AbrilClinica.Entities.DataManagment;
using AbrilClinica.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abril_Clinica.Models
{
    public class User : Parser
    {
        private string _name;
        private string _surname;
        private string _username;
        private string _password;
        private bool _isAdmin;

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }

        [Browsable(false)]
        public bool IsAdmin { get => _isAdmin;}

        protected User(string name, string surname, string username, string password, bool isAdmin)
        {
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
            _isAdmin = isAdmin;
        }

        public User()
        {
        }

        public static explicit operator User(string line)
        {
            string separator = ",";
            string[] row = line.Split(separator);
            
            string name = row[0];
            string surname = row[1];
            string username = row[2];
            string password = row[3];
            bool isAdmin = Convert.ToBoolean(row[4]);
            User user = new User(name, surname, username, password, isAdmin);
            
            return user;
        }

        public override string ObjectToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name},{Surname},{Username},{Password},{IsAdmin}");
            return sb.ToString();
        }

        public override Parser Parse(string line)
        {
            User user = (User)line;
            return user;
        }

    }
}
