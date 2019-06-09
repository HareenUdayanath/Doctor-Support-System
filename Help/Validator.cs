using DoctorSupportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DoctorSupportSystem.Help
{
    class Validator
    {
        private static int[] _31Months = { 1, 3, 5, 7, 8, 10, 12 };
        private static int[] _30Months = { 4, 6, 9, 11};
        /*public static Boolean nicValidator(string ID) { 
            if ((ID.Count(char.IsDigit) == 9) && (ID.EndsWith("X") || ID.EndsWith("V")) && (ID[2] != '4' && ID[2] != '9'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/

        public static bool text(string name)
        {
            return Regex.IsMatch(name, @"^[\p{L}\p{M}' \.\-]+$");
        }

        public static bool email(String email)
        {
            return Regex.IsMatch(email.Trim(), @"\A(?:[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?)\Z");
        }

        public static bool fax(String fax)
        {
            return Regex.IsMatch(fax.Trim(), @"/^\+?[0 - 9]{ 6,}$/");
        }

        public static bool contactNumber(string number)
        {
            return Regex.IsMatch(number, @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
        }

        public static bool nic(string nic)
        {
            return Regex.IsMatch(nic, @"^\d{9}(X|V)$");
        }

        public static bool epf(string epf)
        {
            return true;
        }

        public static bool number(string number)
        {
            return Regex.IsMatch(number, @"^[1-9]\d*$");
        }

        public static bool money(string money)
        {
            return Regex.IsMatch(money, @"^\d+\.\d{0,2}$") || number(money);
        }

        public static bool isValidDateOfBirth(Date date) 
        {
            if (date.getYear() < 1900 || DateTime.Compare(date.getTDate(), DateTime.Today)<0)
                return false;
            return isValidDate(date); 
        }

        public static bool isValidDate(Date date) 
        {
            if (date.getYear() < 0 || date.getMonth() < 1 || date.getDay() < 1)
                return false;
            if (date.getMonth() > 12)
                return false;
            if (_31Months.Contains(date.getMonth()) && date.getDay() > 31)
                return false;
            if (_30Months.Contains(date.getMonth()) && date.getDay() > 30)
                return false;
            if (date.getMonth() == 2)
                if (DateTime.IsLeapYear(date.getYear()))
                {
                    if (date.getDay() > 29)
                        return false;
                }
                else
                {
                    if (date.getDay() > 28)
                        return false;
                }
            return true;   
        }
    }
}
