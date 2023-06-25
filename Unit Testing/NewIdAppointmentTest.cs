using AbrilClinica.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing
{
    [TestClass]
    public class NewIdAppointmentTest
    {
        [TestMethod]
        public void TestValidNewId()
        {
            int id = 1;
            List<Appointment> appointments = new List<Appointment>
            {
                new Appointment(id, 45686325, "Ginecologia", DateTime.Today)
            };

            int result = Appointment.NewIdAppointment(appointments);

            Assert.AreNotEqual(id, result);
        }

    }
}
