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

        /// <summary>
        /// instance the database
        /// </summary>
        public AppointmentController()
        {
            _database = new DataBase();
        }

        /// <summary>
        /// creates a appointment database in case it does not exist
        /// </summary>
        public void CreateAppointments()
        {
            _database.CreateAppointmentArchive();
        }

        /// <summary>
        /// reads the database and returns a list of appointments
        /// </summary>
        /// <returns></returns>
        public List<Appointment> GetAppointments()
        {
            return _database.GetAppointments();
        }

        /// <summary>
        /// create a list with the appointments of the same ID
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public List<Appointment> GetAppointmentsByDniPatient(int dni)
        {
            return _database.GetAppointmentsByDniPatient(dni);
        }

        /// <summary>
        /// Write appointments to a database
        /// </summary>
        /// <param name="appointments"></param>
        public void SetAppointments(List<Appointment> appointments)
        {
            _database.SetAppointments(appointments);
        }
    }
}
