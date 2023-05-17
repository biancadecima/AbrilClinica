using Abril_Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Database
{
    public class AdminController
    {
        private DataBase _database;

        /// <summary>
        /// instance the database
        /// </summary>
        public AdminController()
        {
            _database = new DataBase();
        }

        /// <summary>
        /// creates a admin database in case it does not exist
        /// </summary>
        public void CreateAdmins()
        {
            _database.CreateAdminArchive();
        }

        /// <summary>
        /// reads the database and returns a list of admins
        /// </summary>
        /// <returns></returns>
        public List<Admin> GetAdmins()
        {
            return _database.GetAdmins();
        }

        /// <summary>
        /// return a patient by its username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Admin GetAdminByUsername(string username)
        {
            return _database.GetAdminByUsername(username);
        }
    }
}
