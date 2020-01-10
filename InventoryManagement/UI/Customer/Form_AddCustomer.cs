using InventoryManagement.Controllers.Customer;
using InventoryManagement.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.UI.Customer
{
    public partial class Form_AddCustomer : Form
    {
        FormController_AddCustomer m_controller;
        public Form_AddCustomer()
        {
            InitializeComponent();
            m_controller = new FormController_AddCustomer(this);
        }

        private void btn_ResetCustomer_Click(object sender, EventArgs e)
        {
            m_controller.ResetTextBoxes();
        }

        private void btn_saveCustomer_Click(object sender, EventArgs e)
        {
            m_controller.SaveCustomer();
        }

        private void tb_CustomerName_Validating(object sender, CancelEventArgs e)
        {
            var isValid = Validator.IsValidString(tb_CustomerName.Text.Trim());
            if (!isValid)
            {
                e.Cancel = true;
                tb_CustomerName.Select(0, tb_CustomerName.Text.Length);
                this.customerErrorProvider.SetError(tb_CustomerName, "Name not valid");
            }
        }

        private void tb_customerMobile_Validating(object sender, CancelEventArgs e)
        {
            var isValid = Validator.IsValidMobileNumber(tb_customerMobile.Text.Trim());
            if (!isValid)
            {
                e.Cancel = true;
                tb_customerMobile.Select(0, tb_customerMobile.Text.Length);
                this.customerErrorProvider.SetError(tb_customerMobile, "Mobile number not valid");
            }
        }

        private void tb_CustomerName_Validated(object sender, EventArgs e)
        {
            customerErrorProvider.SetError(tb_CustomerName, "");
        }

        private void tb_customerMobile_Validated(object sender, EventArgs e)
        {
            customerErrorProvider.SetError(tb_customerMobile, "");
        }
    }
}
