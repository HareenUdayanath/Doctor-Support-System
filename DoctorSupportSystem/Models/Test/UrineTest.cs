using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorSupportSystem.Models.Test
{
    class UrineTest : Test
    {
        private float urine_MA;
        private float urine_C;
        private float urine_AC;

        public float Urine_MA
        {
            get
            {
                return urine_MA;
            }

            set
            {
                urine_MA = value;
            }
        }

        public float Urine_C
        {
            get
            {
                return urine_C;
            }

            set
            {
                urine_C = value;
            }
        }

        public float Urine_AC
        {
            get
            {
                return urine_AC;
            }

            set
            {
                urine_AC = value;
            }
        }
    }
}
