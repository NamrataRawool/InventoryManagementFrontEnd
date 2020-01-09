using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Customer;
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
