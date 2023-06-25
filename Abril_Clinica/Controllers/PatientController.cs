using Abril_Clinica.Models;
using AbrilClinica.Entities.Handlers;
using AbrilClinica.Entities.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Database
{
    public class PatientController
    {
        private PatientHandler _patientHandler;

        /// <summary>
        /// instance the database
        /// </summary>
        public PatientController()
        {
            _patientHandler = new PatientHandler();
        }

        /// <summary>
        /// reads the database and returns a list of patients
        /// </summary>
        /// <returns></returns>
        public async Task<List<Patient>> GetPatients()
        {
            return await _patientHandler.GetAll();
        }

        /// <summary>
        /// return a patient by its username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public async Task<Patient> GetPatientByUsername(string username)
        {
            return await _patientHandler.GetByUsername(username);
        }

        public async Task Add(Patient patient)
        {
            await _patientHandler.Add(patient);
        }

        public async Task Update(Patient patient)
        {
            await _patientHandler.Update(patient);
        }

        public async Task Delete(Patient patient)
        {
            await _patientHandler.Delete(patient.Dni);
        }
    }
}
