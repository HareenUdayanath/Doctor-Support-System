using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorSupportSystem.Models.Test
{
    public class ProfileLiverTest : MedicalTest
    {
        private float totalProtein;
        private float albumin;
        private float globumin;
        private float ag_Ratio;
        private float bilirubinTotal;
        private float alkPhosphatase;
        private float alt;
        private float ast;
        private float gamma;

        public float TotalProtein
        {
            get
            {
                return totalProtein;
            }

            set
            {
                totalProtein = value;
            }
        }

        public float Albumin
        {
            get
            {
                return albumin;
            }

            set
            {
                albumin = value;
            }
        }

        public float Globumin
        {
            get
            {
                return globumin;
            }

            set
            {
                globumin = value;
            }
        }

        public float Ag_Ratio
        {
            get
            {
                return ag_Ratio;
            }

            set
            {
                ag_Ratio = value;
            }
        }

        public float BilirubinTotal
        {
            get
            {
                return bilirubinTotal;
            }

            set
            {
                bilirubinTotal = value;
            }
        }

        public float AlkPhosphatase
        {
            get
            {
                return alkPhosphatase;
            }

            set
            {
                alkPhosphatase = value;
            }
        }

        public float Alt
        {
            get
            {
                return alt;
            }

            set
            {
                alt = value;
            }
        }

        public float Ast
        {
            get
            {
                return ast;
            }

            set
            {
                ast = value;
            }
        }

        public float Gamma
        {
            get
            {
                return gamma;
            }

            set
            {
                gamma = value;
            }
        }
    }
}
