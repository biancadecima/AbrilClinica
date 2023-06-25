using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbrilClinica.Entities.Models;
using Abril_Clinica.Models;

namespace AbrilClinica.Entities.Reports
{
    public class ExportJSON : ReportManagment
    {
        public static void AppointmentReportJSON(List<Appointment> appointments)
        {
            string jsonFilePath = "C:\\Users\\Urano\\source\\Decima_Labo2_PP\\PrimerParcial_Labo2\\Turnos.json";

            string jsonData = SerializeObject(appointments);
            File.WriteAllText(jsonFilePath, jsonData);

        }

        public static void PatientReportJSON(List<Patient> patients)
        {
            string jsonFilePath = "C:\\Users\\Urano\\source\\Decima_Labo2_PP\\PrimerParcial_Labo2\\Pacientes.json";

            // Serializar los datos a JSON y escribirlos en el archivo
            //string jsonData = JsonConvert.SerializeObject(patients, Formatting.Indented);

            string jsonData = SerializeObject(patients);
            File.WriteAllText(jsonFilePath, jsonData);

        }
    }
}
