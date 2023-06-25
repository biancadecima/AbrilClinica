using AbrilClinica.Entities.Models;
using AbrilClinica.Entities.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static bool isAdmin { get; }
        public int IdDoctor { get => _idDoctor; set => _idDoctor = value; }
        public string SpecialField { get => _specialField; set => _specialField = value; }

        public Admin() { }

        /// <summary>
        /// initialize an admin with data
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="isAdmin"></param>
        /// <param name="idDoctor"></param>
        /// <param name="specialField"></param>
        public Admin(string name, string surname, string username, string password, bool isAdmin,int idDoctor, string specialField) : base(name, surname, username, password, true)
        {
            _idDoctor = idDoctor;
            _specialField = specialField;
        }

        /// <summary>
        /// convert a string to a admin
        /// </summary>
        /// <param name="line"></param>
        public static explicit operator Admin(DataRow row)
        {
            var name = row["Nombre"].ToString();
            var surname = row["Apellido"].ToString();
            var username = row["Usuario"].ToString();
            var password = row["Contrasenia"].ToString();
            var isAdmin = Convert.ToBoolean(row["EsAdmin"].ToString());
            var idDoctor = Convert.ToInt32(row["IdDoctor"].ToString());
            var specialfield = row["Especialidad"].ToString();

            Admin admin = new Admin(name, surname, username, password, isAdmin, idDoctor, specialfield);

            return admin;
        }

        /// <summary>
        /// convert admin to string
        /// </summary>
        /// <returns></returns>
        public override string ObjectToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ObjectToString());
            sb.Append($",{IdDoctor},{SpecialField}");
            return sb.ToString();
        }

        /// <summary>
        /// parse into a admin
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        //public override Parser Parse(string line)
        //{
        //    Admin admin = (Admin)line;
        //    return admin;

        //}
    }
    
}
