using AbrilClinica.Entities.Models;
using AbrilClinica.Entities.Handlers;
using AbrilClinica.Entities.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Database
{
    public class AdminController
    {
        private AdminHandler _adminHandler;

        /// <summary>
        /// instance the database
        /// </summary>
        public AdminController()
        {
            _adminHandler = new AdminHandler();
        }

        /// <summary>
        /// reads the database and returns a list of admins
        /// </summary>
        /// <returns></returns>
        public async Task<List<Admin>> GetAdmins()
        {
            return await _adminHandler.GetAll();
        }

        /// <summary>
        /// return a patient by its username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public async Task<Admin> GetAdminByUsername(string username)
        {
            return await _adminHandler.GetByUsername(username);
        }
    }
}
