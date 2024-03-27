using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AbrilClinica.Entities.ADO.NET
{
    public class ConnectionSQL
    {
        protected SqlConnection _connection;
        protected static string _connectionString;

        static ConnectionSQL()
        {
            _connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING_AC");
            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new ApplicationException("Connection string not found in environment variables.");
            }
           
        }

        /// <summary>
        /// Opens the connenction
        /// </summary>
        /// <returns></returns>
        public async Task Open()
        {
            _connection = new SqlConnection(_connectionString);
            await _connection.OpenAsync();
        }

        /// <summary>
        /// Closes the connection
        /// </summary>
        public void Close()
        {
            _connection.Close();
        }
    }
}
