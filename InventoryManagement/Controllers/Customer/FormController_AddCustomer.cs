using InventoryManagement.Models;
using InventoryManagement.Services.HTTP;
using InventoryManagement.UI.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
