using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Abril_Clinica.Models
{
    public class Admin : User
    {
        private int _idDoctor;
        private string _specialField;



        public Admin(string name, string surname, string username, string password, bool isAdmin,int idDoctor, string specialField) : base(name, surname, username, password, true)
        {
            _idDoctor = idDoctor;
            _specialField = specialField;
        }

        public static bool isAdmin { get; }
        public int IdDoctor { get => _idDoctor; set => _idDoctor = value; }
        public string SpecialField { get => _specialField; set => _specialField = value; }


        public override string Show()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"Rol: {this.Role}");
            sb.AppendLine(base.Show());
            return sb.ToString();
        }
    }
}
