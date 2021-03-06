﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoctorSupportSystem.Models;
using DoctorSupportSystem.DataBase;
using System.Threading;

namespace DSS_Test
{
    [TestClass]
    public class DataBaseOperatorTest
    {
        DataBaseOperator db = DataBaseOperator.GetInstance();

        [TestMethod]
        public void checkPateintInsertonAndLoad()
        {
            /*
             * Check insertion of a patient to the database
             * Using patient object
             */
            Patient orgPatient = new Patient();
            orgPatient.FirstName = "Udaya";
            orgPatient.LastName = "Gunarathna";            
            orgPatient.DateOfBirth = new Date(new DateTime(1990, 05, 06)); 
            orgPatient.Gender = "Male";
            orgPatient.Address = "Colombo 10";
            orgPatient.Nic = "123654987V";
            orgPatient.ContactNo = "0113365126";

            int re = db.addPatient(orgPatient);


            /*
             * To verify that the patient is added corrctly,
             * load the added patient using nic
             * and compare the loaded patient and added patient 
             */
            Patient loadedPateitn = db.getPatientByNIC(orgPatient.Nic);

            /*
             * If the patient is successfuly added to the database, 
             * the function will return 1
             */
            Assert.AreEqual(re,1);


            /*
             * Compare following values 
             */
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


            /*
             * If the data added successfully to the database, the function returns the number 1
             * Otehrwise negative number will return according to the error   
             */
            int re = db.addUser(orgUser);

            User loadUser = db.getUser(orgUser.Nic);

            /*
             * Should check the insertion function has returned 1
             */
            Assert.AreEqual(re, 1);
            Assert.AreEqual(orgUser.Username, loadUser.Username);
            Assert.AreEqual(orgUser.Position, loadUser.Position);
            Assert.AreEqual(orgUser.Fullname, loadUser.Fullname);
            Assert.AreEqual(orgUser.Gender, loadUser.Gender);
            Assert.AreEqual(orgUser.Nic, loadUser.Nic);
            Assert.AreEqual(orgUser.ContactNo, loadUser.ContactNo);

            /*
             * If the data successfully delete from the database, the function returns the number 1
             * Otehrwise negative number will return according to the error   
             */
            re = db.deleteUser(orgUser.Nic);

            /*
            * Should check the deletion function has returned 1
            */
            Assert.AreEqual(re, 1);
            Assert.IsFalse(db.checkUser(orgUser.Username, orgUser.Password));
            
        }

        [TestMethod]
        public void checkAppointmentInsertionAndDeletion()
        {
            Appointment appointment = new Appointment();
            appointment.Date = new Date(2016,8,2);
            appointment.PatientName = "Sunil Perera";
            appointment.Nic = "456789123V";

            /*
             * Appointment number for a specific date should be number of appointments of that date + 1
             */
            int appointmentNumber = db.getNoOfAppointments(appointment.Date) + 1;
            appointment.Number = appointmentNumber;

            /*
            * If the data added successfully to the database, the function returns the number 1
            * Otehrwise negative number will return according to the error   
            */
            int re = db.addAppointment(appointment);
           

            /*
             * Should check the insertion function has returned 1
             */
            Assert.AreEqual(re,1);
            Assert.AreEqual(appointment.Number, db.getNoOfAppointments(appointment.Date));

            /*
             * If the data successfully delete from the database, the function returns the number 1
             * Otehrwise negative number will return according to the error   
            */
            re = db.deleteAppointment(appointment.Number,appointment.Date);

            /*
             * Should check the deletion function has returned 1
             */
            Assert.AreEqual(re, 1);
            Assert.AreNotEqual(appointment.Number, db.getNoOfAppointments(appointment.Date));
        }

        [TestMethod]
        public void chechDeseaseRecordInsertion()
        {

            /*
             * max rid + 1 should be the next rid 
             */
            int rid = db.getMaxRID() + 1;
            /*
             * Check the insertion using the correct values
             */
            DeseaseReport deseaseRecord = new DeseaseReport();
            deseaseRecord.Pid = 1;
            deseaseRecord.Rid = rid;
            deseaseRecord.Desease = "A";

            /*
             * If the insertion is success, the function return 1
             */
            int re = db.addDeseaseReport(deseaseRecord);

            /*
             * Check whether the correct data is added to the database
             */
            Assert.AreEqual(re,1);

            rid = db.getMaxRID();

            /*
             * After insertion the max rid should be equal to the desease report rid 
             */
            Assert.AreEqual(deseaseRecord.Rid,rid);
                       
            // If the deletion is successful, the deletion function return 1
            //re = db.deleteDeseaseRecord(deseaseRecord.Rid);

            //Assert.AreEqual(re, 1);

          
        }

        [TestMethod]
        public void checkDeseaseReportInsertionWithIncorrectData()
        {
            /*
           * check the insertion using invalid patient id,
           * which is not in the patientdetails table
           */

            DeseaseReport deseaseRecord = new DeseaseReport();
            deseaseRecord.Pid = 15000;
            deseaseRecord.Desease = "B";

            /*
             * If the insertion is success, the function return 1
             * If the insertion fail because of the invalid pid, it will return -2
             */
            int re = db.addDeseaseReport(deseaseRecord);

            /*
             * Check whether the correct data is added to the database
             */
            Assert.AreEqual(re, -2);
        }

       
    }
}
