using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Utilities
{
    public class Validator
    {
        public static bool IsString(string n)
        {

            return !Int32.TryParse(n, out int val) && !String.IsNullOrWhiteSpace(n) && n.Length > 0;

        }

        public static bool IsPassword(string n) 
        { 
            return !String.IsNullOrWhiteSpace(n) && n.Length > 0; 
        }

        public static bool IsDni(string n, out int dni)
        { 
            if(Int32.TryParse(n, out dni))
            {
                if(dni > 1000000)
                {

                    return true;
                }
            }
            return false;
                
        }



        //Int32.TryParse(txb_dniPatient.Text, out int tbx_dni) && cbx_specialField.GetItemText(cbx_specialField.SelectedItem

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
