using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorSupportSystem.Models
{
    class Date
    {
        private DateTime date;
        private int year;
        private int month;
        private int day;


                
        public Date(int year, int month, int day)
        {
            this.date = new DateTime(year, month, day);
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public string getDate()
        {
            //string d1 = date.Date.ToString().Split(' ')[0];
            //string[] dlist =  d1.Split('/');                  
            return year + "-" + month + "-" + day;
        }

        public int getYear() 
        {
            return year;
        }

        public int getMonth() 
        {
            return month;
        }

        public int getDay() 
        {
            return day;
        }

        public DateTime getTDate() 
        {
            return date;
        }
    }
}
