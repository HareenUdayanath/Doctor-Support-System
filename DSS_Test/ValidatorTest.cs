using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorSupportSystem.Help;

namespace DSS_Test
{
    [TestClass]
    public class ValidatorTest
    {
        [TestMethod]
        public void nicLessThan10()
        {
            //Act
            bool result = Validator.nic("12345678V");
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void nicMoreThan10()
        {
            //Act
            bool result = Validator.nic("1234567845V");
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void nicWithoutVorX()
        {
            //Act
            bool result = Validator.nic("1234567897");
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void nicAnotherNotXorV()
        {
            //Act
            bool result = Validator.nic("123456789A");
            //Assert
            Assert.AreEqual(false, result);
        }
    }
}
