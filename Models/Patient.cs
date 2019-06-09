using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorSupportSystem.Models
{
    class Patient
    {
        private int pid;
        private string firstName;
        private string lastName;
        private Date dateOfBirth;
        private string gender;
        private string address;
        private string nic;

        public static string male = "Male";
        public static string feMale = "Female";


        public int PID
        {
            get { return pid; }
            set { pid = value; }
        }


        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        internal Date DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }


        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }


        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public string Nic
        {
            get { return nic; }
            set { nic = value; }
        }

        public string getDateOfBith()
        {
            return dateOfBirth.getDate();
        }

    }
}
