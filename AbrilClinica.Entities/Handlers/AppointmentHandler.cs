using AbrilClinica.Entities.Models;
using AbrilClinica.Entities.SQL;
using Google.Type;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Api.Gax.Grpc.Gcp.AffinityConfig.Types;

namespace AbrilClinica.Entities.Handlers
{
    public class AppointmentHandler : CommandSQL, IManagement<Appointment>
    {
        public AppointmentHandler() { }

        /// <summary>
        /// Adds an appointment to the database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task Add(Appointment entity)
        {
            string query = "INSERT INTO Turnos (Id, DniPaciente, Especialidad, Fecha)" +
                "values (@id, @dniPatient, @specialField, @date)";
            using (var command = await CreateCommand(query))
            {
                command.Parameters.AddWithValue("@id", entity.Id);
                command.Parameters.AddWithValue("@dniPatient", entity.DniPatient);
                command.Parameters.AddWithValue("@specialField", entity.SpecialField);
                command.Parameters.AddWithValue("@date", entity.Date);
                await ExecuteNonQuery(command);
            }
        }

        /// <summary>
        /// Deletes an appointment in the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Delete(int id)
        {
            string query = "DELETE FROM Turnos WHERE Id = @id";
            using (var command = await CreateCommand(query))
            {
                command.Parameters.AddWithValue("@id", id);
                await ExecuteNonQuery(command);
            }    
        }

        /// <summary>
        /// Gets an appointment by its dni patient
        /// </summary>
        /// <param name="dniPatient"></param>
        /// <returns></returns>
        public async Task<List<Appointment>> GetByDniPatient(int dniPatient)
        {
            var appointments = new List<Appointment>();
            string query = "SELECT * FROM Turnos WHERE DniPaciente = @dniPatient";
            using(var command = await CreateCommand(query))
            {
                command.Parameters.AddWithValue("@dniPatient", dniPatient);
                using (var table = await ExecuteReader(command))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        appointments.Add((Appointment)row);
                    }
                }
            }

            return appointments;
        }

        /// <summary>
        /// Gets all the appointments in the database
        /// </summary>
        /// <returns></returns>
        public async Task<List<Appointment>> GetAll()
        {
            var appointments = new List<Appointment>();
            string query = "SELECT * FROM Turnos";
            using(var command = await CreateCommand(query))
            { 
                using(var table = await ExecuteReader(command)) 
                { 
                    foreach (DataRow row in table.Rows)
                    {
                        appointments.Add((Appointment)row);
                    }
                }  
            }
            return appointments;
        }

        /// <summary>
        /// Updates an appointment in the database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task Update(Appointment entity)
        {
            string query = "UPDATE Turnos SET Id = @id, DniPaciente = @dniPatient, Especialidad = @specialField, Fecha = @date WHERE Id = @id";
            using (var command = await CreateCommand(query))
            {
                command.Parameters.AddWithValue("@id", entity.Id);
                command.Parameters.AddWithValue("@dniPatient", entity.DniPatient);
                command.Parameters.AddWithValue("@specialField", entity.SpecialField);
                command.Parameters.AddWithValue("@date", entity.Date);
                await ExecuteNonQuery(command);
            }
        }
    }
}
