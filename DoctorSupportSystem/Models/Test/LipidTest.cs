using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorSupportSystem.Models.Test
{
    public class LipidTest : Test
    {
        private float cholesterolTotal;
        private float triglycerides;
        private float cholesterolHDL;
        private float cholesterolLDL;
        private float cholesterolVLDL;
        private float chol_hdl;
        private float ldl_hdl;

        public float CholesterolTotal
        {
            get
            {
                return cholesterolTotal;
            }

            set
            {
                cholesterolTotal = value;
            }
        }

        public float Triglycerides
        {
            get
            {
                return triglycerides;
            }

            set
            {
                triglycerides = value;
            }
        }

        public float CholesterolHDL
        {
            get
            {
                return cholesterolHDL;
            }

            set
            {
                cholesterolHDL = value;
            }
        }

        public float CholesterolLDL
        {
            get
            {
                return cholesterolLDL;
            }

            set
            {
                cholesterolLDL = value;
            }
        }

        public float CholesterolVLDL
        {
            get
            {
                return cholesterolVLDL;
            }

            set
            {
                cholesterolVLDL = value;
            }
        }

        public float Chol_hdl
        {
            get
            {
                return chol_hdl;
            }

            set
            {
                chol_hdl = value;
            }
        }

        public float Ldl_hdl
        {
            get
            {
                return ldl_hdl;
            }

            set
            {
                ldl_hdl = value;
            }
        }
    }
}
