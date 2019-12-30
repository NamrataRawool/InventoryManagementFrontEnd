using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Utilities
{
    public static class Validator
    {
        public static bool IsInteger(string text)
        {
            if (int.TryParse(text, out int value))
            {
                return true;
            }
            return false;
        }
    }
}
