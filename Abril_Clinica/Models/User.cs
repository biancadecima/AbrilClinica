using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abril_Clinica.Models
{
    public class User : Person
    {
        private string _username;
        private string _password;

        public User(string username, string password, string name, string surname, long dni) : base(name, surname, dni)
        {
            _username = username;
            _password = password;
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
