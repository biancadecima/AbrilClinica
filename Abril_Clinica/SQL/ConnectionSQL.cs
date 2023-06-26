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
            _connectionString = "Server=DESKTOP-7LES993;Database=AbrilClinica;Trusted_Connection=True;";
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
