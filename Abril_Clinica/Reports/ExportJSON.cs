﻿using System;
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
        /// <summary>
        /// serializes appointments and writes it in a json file
        /// </summary>
        /// <param name="appointments"></param>
        public static void AppointmentReportJSON(List<Appointment> appointments)
        {
            string jsonFilePath = "C:\\Users\\Urano\\source\\Decima_Labo2_PP\\PrimerParcial_Labo2\\Turnos.json";

            string jsonData = SerializeObject(appointments);
            File.WriteAllText(jsonFilePath, jsonData);

        }

        /// <summary>
        /// serializes patients and writes it in a json file
        /// </summary>
        /// <param name="patients"></param>
        public static void PatientReportJSON(List<Patient> patients)
        {
            string jsonFilePath = "C:\\Users\\Urano\\source\\Decima_Labo2_PP\\PrimerParcial_Labo2\\Pacientes.json";
            string jsonData = SerializeObject(patients);
            File.WriteAllText(jsonFilePath, jsonData);

        }
    }
}
