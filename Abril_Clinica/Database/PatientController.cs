using Abril_Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Database
{
    public class PatientController
    {
        private DataBase _database;

        /// <summary>
        /// instance the database
        /// </summary>
        public PatientController()
        {
            _database = new DataBase();
        }

        /// <summary>
        /// creates a patients database in case it does not exist
        /// </summary>
        public void CreatePatients()
        {
            _database.CreatePatientArchive();
        }

        /// <summary>
        /// reads the database and returns a list of patients
        /// </summary>
        /// <returns></returns>
        public List<Patient> GetPatients()
        {
            return _database.GetPatients();
        }

        /// <summary>
        /// return a patient by its username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Patient GetPatientByUsername(string username)
        {
            return _database.GetPatientByUsername(username);
        }

        /// <summary>
        /// Write patients to a database
        /// </summary>
        /// <param name="patients"></param>
        public void SetPatients(List<Patient> patients)
        {
            _database.SetPatients(patients);
        }
    }
}
