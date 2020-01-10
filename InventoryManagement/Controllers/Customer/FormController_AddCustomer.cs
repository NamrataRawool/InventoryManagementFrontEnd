using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Customer;
using InventoryManagement.Utilities;
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
                var customer = DataService.Get().GetCustomerDataController().Post(customerPost);
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
                if (!Validator.IsValidEmail(email))
                {
                    m_UIControl.lbl_customerErrorText.Text = "Email Id not valid";
                    return false;
                }
            }

            if (!Validator.IsValidString(name))
            {
                m_UIControl.lbl_customerErrorText.Text = "Name not valid";
                return false;
            }
            if (!Validator.IsValidMobileNumber(mobileNumber))
            {
                m_UIControl.lbl_customerErrorText.Text = "Mobile Number not valid";
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
