using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorSupportSystem.Models.Test
{
    public class HaemoglobinTest : MedicalTest
    {
        private float results;

        public float Results
        {
            get
            {
                return results;
            }

            set
            {
                results = value;
            }
        }
    }
}
