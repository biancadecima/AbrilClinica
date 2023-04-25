using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abril_Clinica.Models
{
    internal class Admin : Person
    {
        public Admin(string name, string surname, long dni, string username, string password) : base(name, surname, dni)
        {
        }


    }
}
