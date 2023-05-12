using Abril_Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Models
{
    public class UserFactory
    {
        public static User CreateUser(User user, int idDoctor, string specialfield, int dni)
        {
            switch (user.IsAdmin )
            {
                case true:
                    return new Admin(user.Name, user.Surname, user.Username, user.Password, true, idDoctor, specialfield);
                case false:
                    return new Patient(user.Name, user.Surname, user.Username, user.Password, false, dni);
                default:
                    throw new ArgumentException($"Tipo de usuario no existente");
            }
        }

        //public static List<Patient> GetPatients(List<User> users)
        //{
        //    foreach (var item in users)
        //    {

        //    }
        //}
    }
}
