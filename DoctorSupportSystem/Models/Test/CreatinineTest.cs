using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorSupportSystem.Models.Test
{
    public class CreatinineTest : MedicalTest
    {
        private float serumCreatinint;
        private float gfr;

        public float SerumCreatinint
        {
            get
            {
                return serumCreatinint;
            }

            set
            {
                serumCreatinint = value;
            }
        }

        public float Gfr
        {
            get
            {
                return gfr;
            }

            set
            {
                gfr = value;
            }
        }
    }
}
