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
            customerDataView.DataSource = GetCustomers();
        }
        private List<CustomerGet> GetCustomers()
        {
            var customers = HTTPService.GET<List<CustomerGet>>("customers");
            var customerDataSource = new List<CustomerGet>();
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
                var name = selectedRow.Cells["Name"].Value.ToString();
                var mobileNumber = selectedRow.Cells["MobileNumber"].Value.ToString();
                var emailId = selectedRow.Cells["Email"].Value.ToString();
                var totalAmount = selectedRow.Cells["TotalAmount"].Value.ToString();
                var pendingAmount = selectedRow.Cells["PendingAmount"].Value.ToString();
                editCustomer.tb_editCustomerName.Text = name;
                editCustomer.tb_editCustomerMobile.Text = mobileNumber;
                editCustomer.tb_editCustomerEmail.Text = emailId;
                editCustomer.tb_editCustomerTotalAmount.Text = totalAmount;
                editCustomer.tb_editCustomerPendingAmount.Text = pendingAmount;
            }

            editCustomer.ShowDialog();
        }
    }
}
