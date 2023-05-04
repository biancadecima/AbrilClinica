using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abril_Clinica.Models
{
    public class Patient : User
    {
        private int _dni;
        
       

        public Patient(string name, string surname, string username, string password, bool isAdmin, int dni) : base(name, surname, username, password, false)
        {
            _dni= dni;
        }

        public static bool isAdmin { get; }
        public int Dni { get => _dni; set => _dni = value; }

        public override string Show()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"Rol: {this.Role}");
            sb.AppendLine(base.Show());
            return sb.ToString();
        }
    }
}
