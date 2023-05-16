using Abril_Clinica.Models;
using AbrilClinica.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Database
{
    public class AppointmentController
    {
        private DataBase _database;
        public AppointmentController()
        {
            _database = new DataBase();
        }

        public void CreateAppointments()
        {
            _database.CreateAppointmentArchive();
        }

        public List<Appointment> GetAppointments()
        {
            return _database.GetAppointments();
        }

        public List<Appointment> GetAppointmentsByDniPatient(int dni)
        {
            return _database.GetAppointmentsByDniPatient(dni);
        }

        public void SetAppointments(List<Appointment> appointments)
        {
            _database.SetAppointments(appointments);
        }
    }
}
