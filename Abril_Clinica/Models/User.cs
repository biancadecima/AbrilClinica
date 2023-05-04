using AbrilClinica.Entities.DataManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abril_Clinica.Models
{
    public class User
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

        public virtual string Show() // polimorfear :)
        {
           StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Name}");
            sb.AppendLine($"Apellido: {this.Surname}");
            sb.AppendLine($"Nombre de Usuario: {this.Username}");
            sb.AppendLine($"Contraseña: {this.Password}");
            return sb.ToString();
        }

    }
}
