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
        public AdminController()
        {
            _database = new DataBase();
        }

        public void CreateAdmins()
        {
            _database.CreateAdminArchive();
        }

        public List<Admin> GetAdmins()
        {
            return _database.GetAdmins();
        }

        public Admin GetAdminByUsername(string username)
        {
            return _database.GetAdminByUsername(username);
        }
    }
}
