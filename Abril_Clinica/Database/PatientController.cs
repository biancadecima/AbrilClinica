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
        public PatientController()
        {
            _database = new DataBase();
        }

        public void CreatePatients()
        {
            _database.CreatePatientArchive();
        }

        public List<Patient> GetPatients()
        {
            return _database.GetPatients();
        }

        public Patient GetPatientByUsername(string username)
        {
            return _database.GetPatientByUsername(username);
        }

        public void SetPatients(List<Patient> patients)
        {
            _database.SetPatients(patients);
        }
    }
}
