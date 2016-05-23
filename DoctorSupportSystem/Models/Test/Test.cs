using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorSupportSystem.Models.Test
{
    public abstract class Test
    {
        private int pid;
        private Date date;

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
