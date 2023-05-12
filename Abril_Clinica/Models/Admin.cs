using AbrilClinica.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public static explicit operator Admin(string line)
        {
            string separator = ",";
            string[] row = line.Split(separator);

            string name = row[0];
            string surname = row[1];
            string username = row[2];
            string password = row[3];
            bool isAdmin = Convert.ToBoolean(row[4]);
            int idDoctor = Convert.ToInt32(row[5]);
            string specialfield = row[6];
            Admin admin = new Admin(name, surname, username, password, isAdmin, idDoctor, specialfield);

            return admin;
        }

        public override string ObjectToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($",{IdDoctor},{SpecialField}");
            return sb.ToString();
        }

        public override Parser Parse(string line)
        {
            Admin admin = (Admin)line;
            return admin;

        }
    }
    
}
