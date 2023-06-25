using Abril_Clinica.Models;
using AbrilClinica.Entities.Models;
using Google.Type;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Reports
{
    public class ExportCSV
    {
        private const string _appointmentPath = "C:\\Users\\Urano\\source\\Decima_Labo2_PP\\PrimerParcial_Labo2\\Turnos.csv";
        private const string _patientPath = "C:\\Users\\Urano\\source\\Decima_Labo2_PP\\PrimerParcial_Labo2\\Pacientes.csv";

        /// <summary>
        /// Write appointments to a database
        /// </summary>
        /// <param name="appointments"></param>
        public static void appointmentReportCSV(List<Appointment> appointments)
        {
            using StreamWriter sw = new StreamWriter(_appointmentPath);
            foreach (var item in appointments)
            {
                sw.WriteLine(item.ObjectToString());
            }

            sw.Close();
        }

        /// <summary>
        /// Write patients to a database
        /// </summary>
        /// <param name="patients"></param>
        public static void patientReportCSV(List<Patient> patients)
        {
            using StreamWriter sw = new StreamWriter(_patientPath);
            foreach (var item in patients)
            {
                sw.WriteLine(item.ObjectToString());
            }

            sw.Close();
        }
    }
}
