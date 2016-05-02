using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorSupportSystem.Help;
using DoctorSupportSystem.Models;

namespace DSS_Test
{

    /*
    Unit tests for testing the Validator class in DoctorSupportSystem/Help. 
        */
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

        [TestMethod]
        public void dateWith30DaysInFrb()
        {
            //Arrange
            Date date = new Date(2000,02,30);
            //Act
            bool result = Validator.isValidDate(date);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void dateWith31InApril()
        {
            //Arrange
            Date date = new Date(2000, 04, 31);
            //Act
            bool result = Validator.isValidDate(date);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void dateWith32InJanuary()
        {
            //Arrange
            Date date = new Date(2000, 01, 32);
            //Act
            bool result = Validator.isValidDate(date);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void dateWith29InFrbInLeepYear()
        {
            //Arrange
            Date date = new Date(2000, 02, 29);
            //Act
            bool result = Validator.isValidDate(date);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void veryLateDate()
        {
            //Arrange
            Date date = new Date(1000,02, 28);
            //Act
            bool result = Validator.isValidDate(date);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void veryLateDateOfBirth()
        {
            //Arrange
            Date date = new Date(1000, 02, 28);
            //Act
            bool result = Validator.isValidDateOfBirth(date);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void futureDate()
        {
            //Arrange
            Date date = new Date(2020, 02, 28);
            //Act
            bool result = Validator.isValidDate(date);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void futureDateOfBirth()
        {
            //Arrange
            Date date = new Date(2020, 02, 28);
            //Act
            bool result = Validator.isValidDateOfBirth(date);
            //Assert
            Assert.AreEqual(false, result);
        }
    }
}
