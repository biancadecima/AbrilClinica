using Abril_Clinica.Models;
using AbrilClinica.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Utilities
{
    public class Harcoder
    {
        public static void HarcodeUsers(List<User> users)
        {
            //var random = new Random();
            users.Add(new User("Rosario", "OSUTHGRA", "Bianca", "Decima", 45686325));
            users.Add(new User("Buenos Aires", "OSDE", "Marcos", "Dente", 54686325));
            users.Add(new User("Rio Negro", "Medicus", "Florencia", "Peña", 98586325));
            users.Add(new User("Chubut", "Galeno", "Simon", "Dice", 78654235));

        }

        public static void HardcodeAppointment(List<Appointment> appointment)
        {
            appointment.Add(new Appointment(1, 45686325, "Ginecologia", new DateTime(2023, 7, 7, 12, 0, 0)));
            appointment.Add(new Appointment(2, 54686325, "Nutricion", new DateTime(2023, 12, 8, 9, 0, 0)));
            appointment.Add(new Appointment(3, 98586325, "Kinesiologia", new DateTime(2023, 5, 6, 14, 30, 0)));
            appointment.Add(new Appointment(4, 78654235, "Obstreticia", new DateTime(2023, 12, 4, 10, 45, 0)));
        }

    }
}
