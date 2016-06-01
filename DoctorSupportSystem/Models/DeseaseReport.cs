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

       
    }
}
