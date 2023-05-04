using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Utilities
{
    public class Validator
    {
        public static bool IsName(string n)
        {
            return !String.IsNullOrWhiteSpace(n) && n.Length > 0;
        }

        //public static bool isValidPatient(string name, string surname, string username, string password, bool isAdmin, int dni)
        //{
        //    if ()
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public static bool isValidAdmin()
        //{
            
        //}

        //public static bool IsValidAppointment()
        //{
            
        //}
    }
}
