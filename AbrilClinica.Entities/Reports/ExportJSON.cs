using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbrilClinica.Entities.Models;

namespace AbrilClinica.Entities.Reports
{
    public class ExportJSON : ReportManagment
    {
        /// <summary>
        /// serializes appointments and writes it in a json file
        /// </summary>
        /// <param name="appointments"></param>
        public static void AppointmentReportJSON(List<Appointment> appointments)
        {
            string jsonFilePath = "./turnos.json";

            string jsonData = SerializeObject(appointments);
            File.WriteAllText(jsonFilePath, jsonData);

        }

        /// <summary>
        /// serializes patients and writes it in a json file
        /// </summary>
        /// <param name="patients"></param>
        public static void PatientReportJSON(List<Patient> patients)
        {
            string jsonFilePath = "./pacientes.json";
            string jsonData = SerializeObject(patients);
            File.WriteAllText(jsonFilePath, jsonData);

        }
    }
}
