using Abril_Clinica.Models;
using AbrilClinica.Entities.Models;
using AbrilClinica.Entities.Utilities;
using Google.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing
{
    [TestClass]
    public class UserExistsTest
    {
        [TestMethod]
        public void TestExistingPacient()
        {
            List<Patient> patients = new List<Patient>
            {
                new Patient("Bianca","Decima","bdecima","coco123",false,45686325)
            };
            List<Admin> admins = new List<Admin>
            {
                new Admin("John","Melano","jmela","mela1",true,501,"Medicina Familiar")
            };

            string username = "bdecima";

            bool result = Session.UserExists(username, patients, admins, out User user);
            
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestExistingAdmin()
        {

            List<Patient> patients = new List<Patient>
            {
                new Patient("Bianca","Decima","bdecima","coco123",false,45686325)
            };
            List<Admin> admins = new List<Admin>
            {
                new Admin("John","Melano","jmela","mela1",true,501,"Medicina Familiar")
            };

            string username = "jmela";

            bool result = Session.UserExists(username, patients, admins, out User user);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestNonExistingUser()
        {

            List<Patient> patients = new List<Patient>
            {
                new Patient("Bianca","Decima","bdecima","coco123",false,45686325)
            };
            List<Admin> admins = new List<Admin>
            {
                new Admin("John","Melano","jmela","mela1",true,501,"Medicina Familiar")
            };

            string username = "nonexisting";

            bool result = Session.UserExists(username, patients, admins, out User user);

            Assert.IsFalse(result);
        }
    }
}
