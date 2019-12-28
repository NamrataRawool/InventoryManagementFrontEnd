using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.Services.HTTP;
using InventoryManagement.Models;
using InventoryManagement.UI.Customer;

namespace InventoryManagement.UI.UserControls
{
    public partial class CustomerControl : UserControl
    {
        public CustomerControl()
        {
            InitializeComponent();

        }
        private void CustomerControl_Load(object sender, EventArgs e)
        {
            customerDataView.DataSource = GetCustomers();
        }
        private List<CustomerGet> GetCustomers()
        {
            var customers = HTTPService.GET<List<CustomerGet>>("customers");
            var customerDataSource = new List<CustomerGet>();
            if (customers == null)
                return null;
            foreach (var customer in customers)
            {
                customerDataSource.Add(customer);
            }
            return customerDataSource;
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            form_addCustomer addCustomer = new form_addCustomer();
            addCustomer.ShowDialog();

        }

        private void btn_editCustomer_Click(object sender, EventArgs e)
        {
            form_editCustomer editCustomer = new form_editCustomer();
            var rows = customerDataView.SelectedRows;
            if (rows.Count > 0)
            {
                int selectedRowIndex = customerDataView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = customerDataView.Rows[selectedRowIndex];
                editCustomer.tb_editCustomerName.Text = selectedRow.Cells["Name"].Value.ToString();
                editCustomer.tb_editCustomerMobile.Text = selectedRow.Cells["MobileNumber"].Value.ToString();
                editCustomer.tb_editCustomerEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                editCustomer.tb_editCustomerTotalAmount.Text = selectedRow.Cells["TotalAmount"].Value.ToString();
                editCustomer.tb_editCustomerPendingAmount.Text = selectedRow.Cells["PendingAmount"].Value.ToString();
            }

            editCustomer.ShowDialog();
        }

    }
}
