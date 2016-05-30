using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorSupportSystem.Models.Test;

namespace DoctorSupportSystem.Models
{
    class DeseaseReport
    {
        private int rid;
        private int pid;
        private string desease;
        private List<MedicalTest> testList = new List<MedicalTest>();

        public int Rid
        {
            get
            {
                return rid;
            }

            set
            {
                rid = value;
            }
        }

        public int Pid
        {
            get
            {
                return pid;
            }

            set
            {
                pid = value;
            }
        }

        public string Desease
        {
            get
            {
                return desease;
            }

            set
            {
                desease = value;
            }
        }

        public List<MedicalTest> TestList
        {
            get
            {
                return testList;
            }
                      
        }
        
        public void addTest(MedicalTest test) {
            testList.Add(test);
        }
    }
}
