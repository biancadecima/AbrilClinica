using AbrilClinica.Entities.ADO.NET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.SQL
{
    public class CommandSQL : ConnectionSQL
    {
        public async Task<SqlCommand> CreateCommand(string query) 
        {
            await Open();
            var command = new SqlCommand(query, _connection);
            return command;
        }

        public async Task<DataTable> ExecuteReader(SqlCommand c)
        {
            var reader = await c.ExecuteReaderAsync();
            var dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();

            return dataTable;
        }

        public async Task ExecuteNonQuery(SqlCommand c)
        {
            await c.ExecuteNonQueryAsync();
        }
    }
}
