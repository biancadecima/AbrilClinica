using Validator = AbrilClinica.Entities.Utilities.Validator;

namespace Unit_Testing
{
    [TestClass]
    public class IsDniTest
    {
        [TestMethod]
        public void TestValidDni()
        {
            string number = "56868991";
            int dni;

            bool result = Validator.IsDni(number, out dni);
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void TestLessThanDni() 
        {
            string number = "7865321";
            int dni;

            bool result = Validator.IsDni(number, out dni);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestInvalidStringDni()
        {
            string number = "NotDni";
            int dni;

            bool result = Validator.IsDni(number, out dni);
            Assert.IsFalse(result);
        }
    }
}