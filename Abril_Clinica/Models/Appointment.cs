//using AbrilClinica.Entities.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
using AbrilClinica.Entities.DataManagment;
using System.Text;
//using System.Threading.Tasks;

namespace AbrilClinica.Entities.Models
{
    public class Appointment
    {
        private int _id;
        private int _dniPatient;
        private string _specialField;
        private DateTime _date;
        private int _idDoctor;

        public int Id { get => _id;}
        public int DniPatient { get => _dniPatient;}
        public string SpecialField { get => _specialField; set => _specialField = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public int IdDoctor { get => _idDoctor; set => _idDoctor = value; }

        public Appointment(int id, int dniPatient, string specialField, DateTime date, int idDoctor)
        {
            _id = id;
            _dniPatient = dniPatient;
            _specialField = specialField;
            _date = date;
            _idDoctor= idDoctor;
        }

        public string Show()
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
