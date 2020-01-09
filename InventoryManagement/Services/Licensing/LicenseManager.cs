using InventoryManagement.Services.Misc.Assert;
using InventoryManagement.UI.Misc.InputBox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Services.Licensing
{
    public static class LicenseManager
    {

        public static bool CheckLicense()
        {

            Initialize();

            // check if license file exists
            if (CheckIfLicenseFileExists())
                return true;

            string userInput = InputBox.Show("Enter Key: ");
            if (string.IsNullOrEmpty(userInput))
                return false;

            if (m_ValidLicenseKey.Equals(userInput))
            {
                MessageBox.Show("Valid License Key!");
                GenerateLicenseFile();
                return true;
            }

            MessageBox.Show("Invalid License Key!");
            return false;
        }

        public static void Initialize()
        {
            DateTime time = DateTime.Now;
            int year = time.Year;
            int month = time.Month + 1;
            int day = time.Day;
            int hour = time.Hour + 1;

            m_ValidLicenseKey = GenerateKey(year, month, day, hour);

            m_LicenseFileName = GetLicenseFileName();
        }

        private static string GenerateKey(int year, int month, int date, int hour)
        {
            string str1 = ((int)Math.Abs((Math.Sin((year * month * date * hour)) * 9999999))).ToString();
            string str2 = ((int)Math.Abs((Math.Cos((year * month * date * hour)) * 9999999))).ToString();
            string result = str1 + str2;
            return result;
        }

        private static bool CheckIfLicenseFileExists()
        {
            return File.Exists(m_LicenseFileName);
        }

        private static void GenerateLicenseFile()
        {
            try
            {
                File.Create(m_LicenseFileName);
            }
            catch (Exception ex)
            {
                Assert.Do(ex.ToString());
            }
        }

        private static string GetLicenseFileName()
        {
            StringBuilder builder = new StringBuilder();

            String query = "SELECT * FROM Win32_BIOS";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            //  This should only find one
            foreach (ManagementObject item in searcher.Get())
            {
                object obj = item["Manufacturer"];
                builder.Append(Convert.ToString(obj));
                obj = item["SerialNumber"];
                builder.Append(Convert.ToString(obj));
            }

            return EncryptFilename(builder.ToString());
        }

        private static string EncryptFilename(string filename)
        {
            string result = "";

            for (int i = 0; i < filename.Length; i++)
                result += (filename[i] + 1);

            return result;
        }

        private static string m_ValidLicenseKey;
        private static string m_LicenseFileName;

    }
}
