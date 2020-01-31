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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Customer
{
    public class FormController_EditCustomer : IController<Form_editCustomer>
    {
        private CustomerGet m_Customer;

        public FormController_EditCustomer(int customerID, Form_editCustomer UIControl) : base(UIControl)
        {
            Initialize(customerID);
        }

        private void Initialize(int customerID)
        {
            m_Customer = DataService.GetCustomerDataController().Get(customerID);

            InitializeProductDetails(customerID);
        }

        public void ResetTextBoxes()
        {
            m_UIControl.tb_customerId.Text = string.Empty;
            m_UIControl.tb_customerName.Text = string.Empty;
            m_UIControl.tb_customerEmail.Text = string.Empty;
            m_UIControl.tb_customerMobileNumber.Text = string.Empty;
            m_UIControl.tb_customerTotalPurchaseAmount.Text = string.Empty;
            m_UIControl.tb_customerPendingAmount.Text = string.Empty;
            m_UIControl.lbl_customerErrorText.Text = string.Empty;
        }

        public void UpdateCustomer()
        {
            m_UIControl.lbl_customerErrorText.Text = string.Empty;

            if (!ValidateCustomerDetails())
                return;

            string name = m_UIControl.tb_customerName.Text.Trim();
            string mobileNumber = m_UIControl.tb_customerMobileNumber.Text.Trim();

            if (CheckIfCustomerNameAlreadyExists(name))
            {
                m_UIControl.lbl_customerErrorText.Text = "Customer with the same Name already exists!";
                return;
            }

            if (CheckIfMobileNumberAlreadyExists(mobileNumber))
            {
                m_UIControl.lbl_customerErrorText.Text = "Customer with the same Mobile Number already exists!";
                return;
            }

            CustomerPost customerPost = new CustomerPost();
            customerPost.ID = int.Parse(m_UIControl.tb_customerId.Text.Trim());
            customerPost.Name = name;
            customerPost.MobileNumber = mobileNumber;
            customerPost.Email = m_UIControl.tb_customerEmail.Text.Trim(); ;
            customerPost.TotalAmount = double.Parse(m_UIControl.tb_customerTotalPurchaseAmount.Text.Trim());
            customerPost.PendingAmount = double.Parse(m_UIControl.tb_customerPendingAmount.Text.Trim());

            m_Customer = DataService.GetCustomerDataController().Put(customerPost);
            if (m_Customer == null)
            {
                m_UIControl.DialogResult = DialogResult.No;
                return;
            }
            m_UIControl.DialogResult = DialogResult.Yes;
            ResetTextBoxes();

            // fire customer updated event
            Event_EntryUpdated e = new Event_EntryUpdated(DBEntityType.CUSTOMER, m_Customer.ID);
            EventBroadcaster.Get().BroadcastEvent(e);
        }

        private bool CheckIfCustomerNameAlreadyExists(string name)
        {
            CustomerGet customer = DataService.GetCustomerDataController().GetByName(name);
            return customer != null && customer.ID != m_Customer.ID;
        }

        private bool CheckIfMobileNumberAlreadyExists(string mobileNumber)
        {
            CustomerGet customer = DataService.GetCustomerDataController().GetByMobileNumber(mobileNumber);
            return customer != null && customer.ID != m_Customer.ID;
        }

        private bool ValidateCustomerDetails()
        {
            m_UIControl.lbl_customerErrorText.Text = string.Empty;
            var email = m_UIControl.tb_customerEmail.Text.Trim();
            var name = m_UIControl.tb_customerName.Text.Trim();
            var mobileNumber = m_UIControl.tb_customerMobileNumber.Text.Trim();
            var totalAmount = m_UIControl.tb_customerTotalPurchaseAmount.Text.Trim();
            var purchaseAmount = m_UIControl.tb_customerPendingAmount.Text.Trim();

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

            if (!Validator.IsValidDouble(totalAmount))
            {
                m_UIControl.lbl_customerErrorText.Text = "Total amount not valid";
                return false;
            }

            if (!Validator.IsValidDouble(purchaseAmount))
            {
                m_UIControl.lbl_customerErrorText.Text = "Purchase amount not valid";
                return false;
            }
            return true;
        }

        private void InitializeProductDetails(int customerId)
        {
            var customer = DataService.GetCustomerDataController().Get(customerId);
            m_UIControl.tb_customerId.Text = customer.ID.ToString();
            m_UIControl.tb_customerName.Text = customer.Name;
            m_UIControl.tb_customerEmail.Text = customer.Email;
            m_UIControl.tb_customerMobileNumber.Text = customer.MobileNumber;
            m_UIControl.tb_customerTotalPurchaseAmount.Text = customer.TotalAmount.ToString();
            m_UIControl.tb_customerPendingAmount.Text = customer.PendingAmount.ToString();
        }


        protected override void RegisterEvents()
        {
        }

    }
}
