using Abril_Clinica.Models;
//using AbrilClinica.Entities.Models;
using AbrilClinica.Entities.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Handlers
{
    public class PatientHandler : CommandSQL, IManagement<Patient>
    {
        public async Task Add(Patient entity)
        {
            string query = "INSERT INTO Paciente (Nombre, Apellido, Usuario, Contrasenia, EsAdmin, Dni)" +
                "values (@name, @surname, @username, @password, @isAdmin, @dni)";
            using (var command = await CreateCommand(query))
            {
                command.Parameters.AddWithValue("@name", entity.Name);
                command.Parameters.AddWithValue("@surname", entity.Surname);
                command.Parameters.AddWithValue("@username", entity.Username);
                command.Parameters.AddWithValue("@password", entity.Password);
                command.Parameters.AddWithValue("@isAdmin", entity.IsAdmin);
                command.Parameters.AddWithValue("@dni", entity.Dni);
                await ExecuteNonQuery(command);
            }
        }

        public async Task Delete(int dni)
        {
            string query = "DELETE Paciente WHERE Dni = @dni";
            using (var command = await CreateCommand(query))
            {
                command.Parameters.AddWithValue("@dni", dni);
                await ExecuteNonQuery(command);
            }
        }

        public async Task<Patient> GetByUsername(string username)
        {
            Patient patient = new Patient();
            string query = "SELECT * FROM Paciente WHERE Usuario = @username";
            using (var command = await CreateCommand(query))
            {
                command.Parameters.AddWithValue("@username", username);
                using (var table = await ExecuteReader(command))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        patient = (Patient)row;
                    }
                }
            }

            return patient;
        }

        public async Task<List<Patient>> GetAll()
        {
            var patients = new List<Patient>();
            string query = "SELECT * FROM Paciente";
            using (var command = await CreateCommand(query))
            {
                using (var table = await ExecuteReader(command))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        patients.Add((Patient)row);
                    }
                }
            }
            return patients;
        }

        public async Task Update(Patient entity)
        {
            string query = "UPDATE Paciente SET Nombre = @name, Apellido = @surname, Usuario = @username, Contrasenia = @password, EsAdmin = @isAdmin, Dni = @dni WHERE Dni = @dni";
            using (var command = await CreateCommand(query))
            {
                command.Parameters.AddWithValue("@name", entity.Name);
                command.Parameters.AddWithValue("@surname", entity.Surname);
                command.Parameters.AddWithValue("@username", entity.Username);
                command.Parameters.AddWithValue("@password", entity.Password);
                command.Parameters.AddWithValue("@isAdmin", entity.IsAdmin);
                command.Parameters.AddWithValue("@dni", entity.Dni);
                await ExecuteNonQuery(command);
            }
        }
    }
}
