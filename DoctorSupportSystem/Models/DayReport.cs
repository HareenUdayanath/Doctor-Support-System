using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorSupportSystem.Models.Test
{
    class DayReport
    {
        private int rid;
        private Date date;
        private List<string> medicines = new List<string>();
        private string condition;

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

        public string Condition
        {
            get
            {
                return condition;
            }

            set
            {
                condition = value;
            }
        }

        public List<string> Medicines
        {
            get
            {
                return medicines;
            }
                       
        }

        public void addMedicine(string medicine)
        {
            if(medicine != null && medicine != "")
                medicines.Add(medicine);
        }
    }
}
