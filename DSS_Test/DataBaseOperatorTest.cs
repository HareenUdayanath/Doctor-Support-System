using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoctorSupportSystem.Models;
using DoctorSupportSystem.DataBase;

namespace DSS_Test
{
    [TestClass]
    public class DataBaseOperatorTest
    {
        DataBaseOperator db = DataBaseOperator.GetInstance();

        [TestMethod]
        public void checkPateintInsertonAndLoad()
        {
            Patient orgPatient = new Patient();
            orgPatient.FirstName = "Udaya";
            orgPatient.LastName = "Gunarathna";            
            orgPatient.DateOfBirth = new Date(new DateTime(1990, 05, 06)); 
            orgPatient.Gender = "Male";
            orgPatient.Address = "Colombo 10";
            orgPatient.Nic = "123654987V";
            orgPatient.ContactNo = "0113365126";

            db.addPatient(orgPatient);

            Patient loadedPateitn = db.getPatientByNIC(orgPatient.Nic);

            Assert.AreEqual(orgPatient.FirstName, loadedPateitn.FirstName);
            Assert.AreEqual(orgPatient.LastName, loadedPateitn.LastName);
            Assert.AreEqual(orgPatient.DateOfBirth.getDate(), loadedPateitn.DateOfBirth.getDate());
            Assert.AreEqual(orgPatient.Gender, loadedPateitn.Gender);
            Assert.AreEqual(orgPatient.Address, loadedPateitn.Address);
            Assert.AreEqual(orgPatient.Nic,loadedPateitn.Nic);
            Assert.AreEqual(orgPatient.ContactNo, loadedPateitn.ContactNo);

        }

        [TestMethod]
        public void checkUserInsertionDeleteLoadCheck()
        {
            User orgUser = new User();
            orgUser.Username = "TestUser";
            orgUser.Password = "TestUserPassword";
            orgUser.Position = "Assistance";
            orgUser.Fullname = "Sumudu Perera";
            orgUser.Gender = "Male";
            orgUser.Nic = "123798456V";
            orgUser.ContactNo = "0113365423";

            int re = db.addUser(orgUser);

            User loadUser = db.getUser(orgUser.Nic);

            Assert.AreEqual(re, 1);
            Assert.AreEqual(orgUser.Username, loadUser.Username);
            Assert.AreEqual(orgUser.Position, loadUser.Position);
            Assert.AreEqual(orgUser.Fullname, loadUser.Fullname);
            Assert.AreEqual(orgUser.Gender, loadUser.Gender);
            Assert.AreEqual(orgUser.Nic, loadUser.Nic);
            Assert.AreEqual(orgUser.ContactNo, loadUser.ContactNo);

            re = db.deleteUser(orgUser.Nic);

            Assert.AreEqual(re, 1);
            Assert.IsFalse(db.checkUser(orgUser.Username, orgUser.Password));
            
        }
    }
}
