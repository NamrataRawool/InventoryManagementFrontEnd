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
            return Regex.IsMatch(integer, integerPattern);
        }

        public static bool IsValidDouble(string number)
        {
            string doublePattern = @"^[0-9]*(?:\.[0-9]*)?$";
            return Regex.IsMatch(number, doublePattern);
        }
        public static bool IsValidString(string name)
        {
            string namePattern = @"^[A-z][A-z|\s]+$";
            return Regex.IsMatch(name, namePattern);
        }
        public static bool IsValidMobileNumber(string mobileNumber)
        {
            string mobileNumberPattern = @"^[0-9]{10}$";
            return Regex.IsMatch(mobileNumber, mobileNumberPattern);
        }
        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
            if (!Regex.IsMatch(email, emailPattern))
                try
                {
                    var mail = new System.Net.Mail.MailAddress(email);
                    return true;
                }
                catch
                {
                    return false;
                }
            return true;
        }
    }
}
