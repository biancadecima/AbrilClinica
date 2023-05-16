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

namespace AbrilClinica.Entities.Database
{
    public class DataBase
    {
        private const string _appointmentPath = "C:\\Users\\Urano\\source\\Decima_Labo2_PP\\PrimerParcial_Labo2\\appointment.csv";
        private const string _userPath = "C:\\Users\\Urano\\source\\Decima_Labo2_PP\\PrimerParcial_Labo2\\user.csv";
        private const string _adminPath = "C:\\Users\\Urano\\source\\Decima_Labo2_PP\\PrimerParcial_Labo2\\admin.csv";
        private const string _patientPath = "C:\\Users\\Urano\\source\\Decima_Labo2_PP\\PrimerParcial_Labo2\\patient.csv";

        public DataBase()
        {
        }

        public void CreateUserArchive()
        {
            if (!File.Exists(_userPath))
            {
                using (StreamWriter sw = new StreamWriter(_userPath))
                {
                    sw.WriteLine("Bianca,Decima,bdecima,coco123,false,45686325");
                    sw.WriteLine("Marcos,Dente,holamarcos,holahola,false,54686325");
                    sw.WriteLine("Florencia,Peña,fpenia,fifus,false,98586325");
                    sw.WriteLine("Simon,Dice,sidimonce,98pepe,false,78654235");

                    sw.WriteLine("John,Melano,jmela,mela1,true,501,Medicina Familiar");
                    sw.WriteLine("Carlos,Horia,horiac,horica00,true,406,Ginecologia");
                    sw.WriteLine("Sofia,Munro,smunro,rofia77, true, 407,Nutricion");
                    sw.WriteLine("Sergio,Hernandez,shernan,nandez88,true,408,Kinesiologia");
                    sw.WriteLine("Mauro,Casorio,msorio,cauro22,true,406,Obstetricia");
                }
            }
           

        }
        public void CreatePatientArchive()
        {
            if (!File.Exists(_patientPath))
            {
                using StreamWriter sw = new StreamWriter(_patientPath);
                sw.WriteLine("Bianca,Decima,bdecima,coco123,false,45686325");
                sw.WriteLine("Marcos,Dente,holamarcos,holahola,false,54686325");
                sw.WriteLine("Florencia,Peña,fpenia,fifus,false,98586325");
                sw.WriteLine("Simon,Dice,sidimonce,98pepe,false,78654235");
            }
        }

        public void CreateAdminArchive()
        {
            if (!File.Exists(_adminPath))
            {
                using StreamWriter sw = new StreamWriter(_adminPath);
                sw.WriteLine("John,Melano,jmela,mela1,true,501,Medicina Familiar");
                sw.WriteLine("Carlos,Horia,horiac,horica00,true,406,Ginecologia");
                sw.WriteLine("Sofia,Munro,smunro,rofia77, true, 407,Nutricion");
                sw.WriteLine("Sergio,Hernandez,shernan,nandez88,true,408,Kinesiologia");
                sw.WriteLine("Mauro,Casorio,msorio,cauro22,true,406,Obstetricia");
            }
        }

        public void CreateAppointmentArchive()
        {
            if (!File.Exists(_appointmentPath))
            {
                using StreamWriter sw = new StreamWriter(_appointmentPath);

                sw.WriteLine("4005,98586325,Medicina Familiar,2023/7/7");
                sw.WriteLine("1,45686325,Ginecologia,2023/7/7");
                sw.WriteLine("2,54686325,Nutricion,2023/12/8");
                sw.WriteLine("4,78654235,Obstreticia,2023/12/4");
                sw.WriteLine("3,98586325,Kinesiologia,2023/5/6");
            }
        }

        public string Read(string path) 
        {
            var text = File.ReadAllText(path);
            return text;
        }
        
        
        public List<Appointment> GetAppointments()
        {
            string text = Read(_appointmentPath);
            string[] line = text.Split('\n');
            List<string> appointmentStringList = new List<string>();
            List<Appointment> appointmentList = new List<Appointment>();

            for(int i = 0; i < line.Length -1; i++)
            {
                appointmentStringList.Add(line[i]);
            }
            foreach (string row in appointmentStringList)
            {
                appointmentList.Add((Appointment)row);
            }

            return appointmentList;
        }

        public List<Appointment> GetAppointmentsByDniPatient(int dni)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            appointmentList = GetAppointments();
            List<Appointment> appointmentsByDniList = new List<Appointment>();
            foreach (Appointment appointment in appointmentList)
            {
                if (appointment.DniPatient == dni)
                {
                    appointmentsByDniList.Add(appointment);
                }
            }
            return appointmentsByDniList;
        }

        public List<Patient> GetPatients()
        {
            string text = Read(_patientPath);
            string[] line = text.Split('\n');
            List<string> patientStringList = new List<string>();
            List<Patient> patientList = new List<Patient>();

            for (int i = 0; i < line.Length - 1; i++)
            {
                patientStringList.Add(line[i]);
            }
            foreach (string row in patientStringList)
            {
                patientList.Add((Patient)row);
            }

            return patientList;
        }

        public Patient GetPatientByUsername(string username)
        {
            List<Patient> patientList = new List<Patient>();
            patientList = GetPatients();
            foreach(Patient patient in patientList)
            {
                if(patient.Username == username)
                {
                    return patient;
                }
            }
            throw new ArgumentException($"Nombre usuario no existente");
        }

        public List<Admin> GetAdmins()
        {
            string text = Read(_adminPath);
            string[] line = text.Split('\n');
            List<string> adminStringList = new List<string>();
            List<Admin> adminList = new List<Admin>();

            for (int i = 0; i < line.Length - 1; i++)
            {
                adminStringList.Add(line[i]);
            }
            foreach (string row in adminStringList)
            {
                adminList.Add((Admin)row);
            }

            return adminList;
        }

        public Admin GetAdminByUsername(string username)
        {
            List<Admin> adminList = new List<Admin>();
            adminList = GetAdmins();
            foreach (Admin admin in adminList)
            {
                if (admin.Username == username)
                {
                    return admin;
                }
            }
            throw new ArgumentException($"Nombre usuario no existente");
        }

        public List<User> GetUsers()
        {
            string text = Read(_userPath);
            string[] line = text.Split('\n');
            List<string> userStringList = new List<string>();
            List<User> userList = new List<User>();

            for (int i = 0; i < line.Length - 1; i++)
            {
                userStringList.Add(line[i]);
            }
            foreach (string row in userStringList)
            {
                userList.Add((User)row);
            }

            return userList;
        }


        public void SetAppointments(List<Appointment> appointments)
        {
            using StreamWriter sw = new StreamWriter(_appointmentPath);
            foreach (var item in appointments)
            {
                sw.WriteLine(item.ObjectToString());
            }

            sw.Close();
        }

        public void SetPatients(List<Patient> patients)
        {
            using StreamWriter sw = new StreamWriter(_patientPath);
            foreach (var item in patients)
            {
                sw.WriteLine(item.ObjectToString());
            }
        }

        public void SetAdmins(List<Admin> admins)
        {
            using StreamWriter sw = new StreamWriter(_adminPath);
            foreach (var item in admins)
            {
                sw.WriteLine(item.ObjectToString());
            }
        }

        public void SetUsers(List<Patient> patients)
        {
            using StreamWriter sw = new StreamWriter(_userPath);
            List<Admin> admins = new List<Admin>();
            List<User> users = new List<User>();
            admins = GetAdmins();
            foreach(var item in admins)
            {
                User user = item;
                users.Add(user);
            }
            foreach (var item in patients)
            {
                User user = item;
                users.Add(user);
            }
            foreach (var item in users)
            {
               sw.WriteLine(item.ObjectToString());
            }
        }
    }
}
