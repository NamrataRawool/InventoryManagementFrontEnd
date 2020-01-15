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
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                return false;
            }
            return true;
        }
    }
}
