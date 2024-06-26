﻿using AbrilClinica.Entities.Models;
using AbrilClinica.Entities.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Handlers
{
    public class AdminHandler : CommandSQL
    {
        /// <summary>
        /// Gets all the admins in the database
        /// </summary>
        /// <returns></returns>
        public async Task<List<Admin>> GetAll()
        {
            var admins = new List<Admin>();
            string query = "SELECT * FROM Administrador";
            using (var command = await CreateCommand(query))
            {
                using (var table = await ExecuteReader(command))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        admins.Add((Admin)row);
                    }
                }
            }
            return admins;
        }

        /// <summary>
        /// Gets the admin in the database by its username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public async Task<Admin> GetByUsername(string username)
        {
            Admin admin = new Admin();
            string query = "SELECT * FROM Administrador WHERE Usuario = @username";
            using (var command = await CreateCommand(query))
            {
                command.Parameters.AddWithValue("@username", username);
                using (var table = await ExecuteReader(command))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        admin = (Admin)row;
                    }
                }
            }

            return admin;
        }
    }
}
