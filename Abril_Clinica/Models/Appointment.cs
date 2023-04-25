using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Models
{
    public class Appointment
    {
        private int _id;
        private int _dniPatient;
        private string _specialField;
        private DateTime _date;

        public int Id { get => _id;}
        public int DniPatient { get => _dniPatient;}
        public string SpecialField { get => _specialField; set => _specialField = value; }
        public DateTime Date { get => _date; set => _date = value; }
        
        public Appointment(int id, int dniPatient, string specialField, DateTime date)
        {
            _id = id;
            _dniPatient = dniPatient;
            _specialField = specialField;
            _date = date;
        }

        public string ShowAppointment()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {_id}");
            sb.AppendLine($"DNI Paciente: {_dniPatient}");
            sb.AppendLine($"Especialidad: {_specialField}");
            sb.AppendLine($"Fecha: {_date}");

            return sb.ToString();
        }
        
    }
}
