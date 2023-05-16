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
        public UserController() 
        {
            _database = new DataBase();
        }

        public void CreateUsers()
        {
            _database.CreateUserArchive();
        }

        public List<User> GetUsers()
        {
            return _database.GetUsers();
        }

        public void SetUsers(List<Patient> patients)
        {
            _database.SetUsers(patients);
        }


    }
}
