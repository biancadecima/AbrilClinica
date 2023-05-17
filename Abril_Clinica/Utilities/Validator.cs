using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Utilities
{
    public class Validator
    {
        /// <summary>
        /// verify that the data is a valid string
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsString(string n)
        {

            return !Int32.TryParse(n, out int val) && !String.IsNullOrWhiteSpace(n) && n.Length > 0;

        }

        /// <summary>
        /// verify that the data is a valid password
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPassword(string n) 
        { 
            return !String.IsNullOrWhiteSpace(n) && n.Length > 0; 
        }

        /// <summary>
        /// verify that the data is a valid ID
        /// </summary>
        /// <param name="n"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
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

        /// <summary>
        /// validates that an entered ID is equal to the ID of a patient
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="dniPtient"></param>
        /// <returns></returns>
        public static bool IsDniSameAsDniPatient(int dni, int dniPtient)
        {
            return dni == dniPtient;
        }
    }
}
