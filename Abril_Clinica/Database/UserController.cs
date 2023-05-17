using Abril_Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Database
{
    public class UserController
    {
        private DataBase _database;

        /// <summary>
        /// instance the database
        /// </summary>
        public UserController() 
        {
            _database = new DataBase();
        }

        /// <summary>
        /// creates a users database in case it does not exist
        /// </summary>
        public void CreateUsers()
        {
            _database.CreateUserArchive();
        }

        /// <summary>
        /// reads the database and returns a list of users
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            return _database.GetUsers();
        }

        /// <summary>
        /// Write patients and admin to a database
        /// </summary>
        /// <param name="patients"></param>
        public void SetUsers(List<Patient> patients)
        {
            _database.SetUsers(patients);
        }


    }
}
