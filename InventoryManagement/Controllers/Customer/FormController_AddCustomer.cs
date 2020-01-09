using InventoryManagement.Models;
using InventoryManagement.Services.HTTP;
using InventoryManagement.UI.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Customer
{
    public class FormController_AddCustomer : IController<Form_AddCustomer>
    {
        public FormController_AddCustomer(Form_AddCustomer UIControl)
           : base(UIControl)
        {
        }
        public void SaveCustomer()
        {
            m_UIControl.lbl_customerErrorText.Text = string.Empty;
            if (ValidateCustomerDetails())
            {
                CustomerPost customerPost = new CustomerPost();
                customerPost.Email = m_UIControl.tb_customerEmail.Text;
                customerPost.Name = m_UIControl.tb_CustomerName.Text;
                customerPost.MobileNumber = m_UIControl.tb_customerMobile.Text;
                customerPost.PendingAmount = 0;
                var customer = HTTPService.POST<CustomerGet, CustomerPost>("customer", customerPost);
                if (customer != null)
                    m_UIControl.DialogResult = DialogResult.Yes;
                else
                    m_UIControl.DialogResult = DialogResult.No;
                m_UIControl.Close();
            }
        }

        private bool ValidateCustomerDetails()
        {
            m_UIControl.lbl_customerErrorText.Text = string.Empty;
            var email = m_UIControl.tb_customerEmail.Text;
            var name = m_UIControl.tb_CustomerName.Text;
            var mobileNumber = m_UIControl.tb_customerMobile.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(mobileNumber))
            {
                m_UIControl.lbl_customerErrorText.Text = "Fields cannot be empty";
                return false;
            }

            if (!string.IsNullOrEmpty(email))
            {
                if (!IsValidEmail(email))
                    return false;
            }

            if (!IsValidName(name))
                return false;
            if (!IsValidMobileNumber(mobileNumber))
                return false;

            return true;
        }

        public bool IsValidName(string name)
        {
            m_UIControl.lbl_customerErrorText.Text = string.Empty;
            string namePattern = @"^[A-z][A-z|\s]+$";
            if (!Regex.IsMatch(name, namePattern))
            {
                m_UIControl.lbl_customerErrorText.Text = "Name not valid!";
                return false;
            }
            return true;
        }

        public bool IsValidMobileNumber(string mobileNumber)
        {
            m_UIControl.lbl_customerErrorText.Text = string.Empty;
            string mobileNumberPattern = @"^[0-9]{10}$";
            if (!Regex.IsMatch(mobileNumber, mobileNumberPattern))
            {
                m_UIControl.lbl_customerErrorText.Text = "Mobile number not valid";
                return false;
            }
            return true;
        }

        public bool IsValidEmail(string email)
        {
            m_UIControl.lbl_customerErrorText.Text = string.Empty;
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                m_UIControl.lbl_customerErrorText.Text = "Email Id not valid!";
                return false;
            }
            return true;
        }

        public void ResetTextBoxes()
        {
            m_UIControl.tb_customerEmail.Text = string.Empty;
            m_UIControl.tb_customerMobile.Text = string.Empty;
            m_UIControl.tb_CustomerName.Text = string.Empty;
        }
        protected override void RegisterEvents()
        {

        }
    }
}
