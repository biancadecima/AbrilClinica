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

        public Patient(string name, string surname, string username, string password, bool isAdmin, int dni) : base(name, surname, username, password, false)
        {
            _dni = dni;
        }

        public int Dni { get => _dni; set => _dni = value; }

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

        public override string ObjectToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($",{Dni}");
            return sb.ToString();
        }

        public override Parser Parse(string line)
        {
            Patient patient = (Patient)line;
            return patient;
        }
    }
}
