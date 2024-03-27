using AbrilClinica.Entities.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Models
{
    public class Patient : User
    {
        private int _dni;

        public int Dni { get => _dni; set => _dni = value; }

        public Patient() { }

        /// <summary>
        /// initialize a patient with data
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="isAdmin"></param>
        /// <param name="dni"></param>
        public Patient(string name, string surname, string username, string password, bool isAdmin, int dni) : base(name, surname, username, password, false)
        {
            _dni = dni;
        }

        /// <summary>
        /// convert a string to a patient
        /// </summary>
        /// <param name="line"></param>
        public static explicit operator Patient(DataRow row)
        {
            var name = row["Nombre"].ToString();
            var surname = row["Apellido"].ToString();
            var username = row["Usuario"].ToString();
            var password = row["Contrasenia"].ToString();
            var isAdmin = Convert.ToBoolean(row["EsAdmin"].ToString());
            var dni = Convert.ToInt32(row["Dni"].ToString());

            Patient patient = new Patient(name, surname, username, password, isAdmin, dni);

            return patient;
        }

        /// <summary>
        /// convert patient to string
        /// </summary>
        /// <returns></returns>
        public override string ObjectToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ObjectToString());
            sb.Append($",{Dni}");
            return sb.ToString();
        }
    }
}
