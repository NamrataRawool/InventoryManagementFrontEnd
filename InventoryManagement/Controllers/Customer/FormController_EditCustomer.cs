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
        public FormController_EditCustomer(int customerId, Form_editCustomer UIControl) : base(UIControl)
        {
            Initialize(customerId);
        }

        private void Initialize(int customerId)
        {
            InitializeProductDetails(customerId);
        }
        public void ResetTextBoxes()
        {
            m_UIControl.tb_customerId.Text = string.Empty;
            m_UIControl.tb_customerName.Text = string.Empty;
            m_UIControl.tb_customerEmail.Text = string.Empty;
            m_UIControl.tb_customerMobileNumber.Text = string.Empty;
            m_UIControl.tb_customerTotalPurchaseAmount.Text = string.Empty;
            m_UIControl.tb_customerPendingAmount.Text = string.Empty;
        }

        public void UpdateCustomer()
        {
            if (ValidateCustomerDetails())
            {
                CustomerPost customerPost = new CustomerPost();
                customerPost.ID = Convert.ToInt32(m_UIControl.tb_customerId.Text);
                customerPost.Name = m_UIControl.tb_customerName.Text;
                customerPost.Email = m_UIControl.tb_customerEmail.Text;
                customerPost.MobileNumber = m_UIControl.tb_customerMobileNumber.Text;
                customerPost.TotalAmount = Convert.ToInt32(m_UIControl.tb_customerTotalPurchaseAmount.Text);
                customerPost.PendingAmount = Convert.ToInt32(m_UIControl.tb_customerPendingAmount.Text);

                var customer = DataService.Get().GetCustomerDataController().Put(customerPost);
                if (customer == null)
                {
                    m_UIControl.DialogResult = DialogResult.No;
                    return;
                }
                m_UIControl.DialogResult = DialogResult.Yes;
            }
        }
        private bool ValidateCustomerDetails()
        {
            m_UIControl.lbl_customerErrorText.Text = string.Empty;
            var email = m_UIControl.tb_customerEmail.Text;
            var name = m_UIControl.tb_customerName.Text;
            var mobileNumber = m_UIControl.tb_customerMobileNumber.Text;
            var totalAmount = m_UIControl.tb_customerTotalPurchaseAmount.Text;
            var purchaseAmount = m_UIControl.tb_customerPendingAmount.Text;

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

            if(!Validator.IsInteger(totalAmount))
            {
                m_UIControl.lbl_customerErrorText.Text = "Total amount not valid";
                return false;
            }

            if (!Validator.IsInteger(purchaseAmount))
            {
                m_UIControl.lbl_customerErrorText.Text = "Purchase amount not valid";
                return false;
            }
            return true;
        }
        private void InitializeProductDetails(int customerId)
        {
            var customer = DataService.Get().GetCustomerDataController().Get(customerId);
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
