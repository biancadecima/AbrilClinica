using AbrilClinica.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Abril_Clinica.Models
{
    public class Patient : User
    {
        private int _dni;

        public int Dni { get => _dni; set => _dni = value; }

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
        public static explicit operator Patient(string line)
        {
            string separator = ",";
            string[] row = line.Split(separator);
            string name = row[0];
            string surname = row[1];
            string username = row[2];
            string password = row[3];
            bool isAdmin = Convert.ToBoolean(row[4]);
            int dni = Convert.ToInt32(row[5]);
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

        /// <summary>
        /// parse into a patient
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public override Parser Parse(string line)
        {
            Patient patient = (Patient)line;
            return patient;
        }
    }
}
