using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InventoryManagement.Utilities
{
    public static class Validator
    {
        public static bool IsInteger(string integer)
        {
            string integerPattern = @"^[0-9]{1,}$";
            if (!Regex.IsMatch(integer, integerPattern))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidDouble(string number)
        {
            string doublePattern = @"^[0-9]*(?:\.[0-9]*)?$";
            if (!Regex.IsMatch(number, doublePattern))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidString(string name)
        {
            string namePattern = @"^[A-z][A-z|\s]+$";
            if (!Regex.IsMatch(name, namePattern))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidMobileNumber(string mobileNumber)
        {
            string mobileNumberPattern = @"^[0-9]{10}$";
            if (!Regex.IsMatch(mobileNumber, mobileNumberPattern))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
