using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorSupportSystem.Models
{
    public class Appointment
    {
        private int number;
        private Date date;
        private string patientName;
        private string nic;

      
        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public string PatientName
        {
            get
            {
                return patientName;
            }

            set
            {
                patientName = value;
            }
        }

        public string Nic
        {
            get
            {
                return nic;
            }

            set
            {
                nic = value;
            }
        }

        public Date Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
    }
}
