using InventoryManagement.Broadcaster;
using InventoryManagement.Events.Common;
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
        private CustomerGet m_Customer;

        public FormController_AddCustomer(Form_AddCustomer UIControl)
           : base(UIControl)
        {
        }

        public void SaveCustomer()
        {
            m_UIControl.lbl_customerErrorText.Text = string.Empty;
            if (!ValidateCustomerDetails())
                return;

            CustomerPost customerPost = new CustomerPost();
            customerPost.Email = m_UIControl.tb_customerEmail.Text.Trim();
            customerPost.Name = m_UIControl.tb_CustomerName.Text.Trim();
            customerPost.MobileNumber = m_UIControl.tb_customerMobile.Text.Trim();
            customerPost.PendingAmount = 0;
            m_Customer = DataService.GetCustomerDataController().Post(customerPost);

            m_UIControl.DialogResult = (m_Customer == null) ? DialogResult.No : DialogResult.Yes;

            // fire customer added event
            Event_NewEntryAdded e = new Event_NewEntryAdded(DBEntityType.CUSTOMER, m_Customer.ID);
            EventBroadcaster.Get().BroadcastEvent(e);
        }

        private bool ValidateCustomerDetails()
        {
            m_UIControl.lbl_customerErrorText.Text = string.Empty;
            var email = m_UIControl.tb_customerEmail.Text.Trim();
            var name = m_UIControl.tb_CustomerName.Text.Trim();
            var mobileNumber = m_UIControl.tb_customerMobile.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                m_UIControl.lbl_customerErrorText.Text = "Name cannot be empty";
                return false;
            }
            if (string.IsNullOrEmpty(mobileNumber))
            {
                m_UIControl.lbl_customerErrorText.Text = "Mobile number cannot be empty";
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

            // check if customer with same mobile number exists
            CustomerGet customer = DataService.GetCustomerDataController().GetByMobileNumber(mobileNumber);
            if (customer != null)
            {
                m_UIControl.lbl_customerErrorText.Text = "Customer with same Mobile Number already exists!";
                return false;
            }

            var customerWithSameName = DataService.GetCustomerDataController().GetByName (m_UIControl.tb_CustomerName.Text.Trim());
            if (customerWithSameName != null)
            {
                m_UIControl.lbl_customerErrorText.Text = "Customer with same name already exists!";
                return false;
            }
            return true;
        }

        public void ResetTextBoxes()
        {
            m_UIControl.tb_customerEmail.Text = string.Empty;
            m_UIControl.tb_customerMobile.Text = string.Empty;
            m_UIControl.tb_CustomerName.Text = string.Empty;
            m_UIControl.lbl_customerErrorText.Text = string.Empty;
        }

        protected override void RegisterEvents()
        {
        }

        public CustomerGet GetCustomer() { return m_Customer; }

    }
}
