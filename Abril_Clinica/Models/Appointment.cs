//using AbrilClinica.Entities.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;

using Abril_Clinica.Models;
using System.Text;
//using System.Threading.Tasks;

namespace AbrilClinica.Entities.Models
{
    public class Appointment : Parser
    {
        private int _id;
        private int _dniPatient;
        private string _specialField;
        private DateTime _date;
       // private int _idDoctor;

        public int Id { get => _id;}
        public int DniPatient { get => _dniPatient;}
        public string SpecialField { get => _specialField; set => _specialField = value; }
        public DateTime Date { get => _date; set => _date = value; }
        //public int IdDoctor { get => _idDoctor; set => _idDoctor = value; }

        public Appointment(int id, int dniPatient, string specialField, DateTime date /*, int idDoctor*/)
        {
            _id = id;
            _dniPatient = dniPatient;
            _specialField = specialField;
            _date = date;
           // _idDoctor= idDoctor;
        }

        public static explicit operator Appointment(string line)
        {
            string separator = ",";
            string[] row = line.Split(separator);

            int id = Convert.ToInt32(row[0]);
            int dniPatient = Convert.ToInt32(row[1]);
            string specialField = row[2];
            DateTime date = DateTime.Parse(row[3]);
            Appointment appt = new Appointment(id, dniPatient, specialField, date);

            return appt;
        }

        public override string ObjectToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Id},{DniPatient},{SpecialField},{Date}");
            return sb.ToString();
        }

        public override Parser Parse(string line)
        {
            Appointment appointment = (Appointment)line;
            return appointment;
        }


    }
}
