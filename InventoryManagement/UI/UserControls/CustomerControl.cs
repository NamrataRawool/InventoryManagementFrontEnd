using System;
using System.Windows.Forms;
using InventoryManagement.Controllers.Customer;

namespace InventoryManagement.UI.UserControls
{
    public partial class CustomerControl : UserControl
    {
        CustomerContoller m_controller;

        public CustomerControl()
        {
            InitializeComponent();
        }

        private void CustomerControl_Load(object sender, EventArgs e)
        {
            m_controller = new CustomerContoller(this);
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            m_controller.OpenForm_AddCustomer();
        }

        private void btn_editCustomer_Click(object sender, EventArgs e)
        {
            m_controller.OpenForm_EditCustomer();
        }

        private void btn_searchCustomer_Click(object sender, EventArgs e)
        {
            m_controller.UpdateTableByCustomerName(tb_searchCustomer.Text.Trim());
        }

        private void tb_searchCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                m_controller.UpdateTableByCustomerName(tb_searchCustomer.Text.Trim());
            }
        }

        private void tb_searchCustomer_TextChanged(object sender, EventArgs e)
        {
            m_controller.UpdateTableByCustomerName(tb_searchCustomer.Text.Trim());
        }

        private void customerDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            m_controller.OpenForm_EditCustomer();
        }
    }
}
