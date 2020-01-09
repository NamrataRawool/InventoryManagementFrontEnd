using InventoryManagement.Models;
using InventoryManagement.Services.HTTP;
using InventoryManagement.UI.Customer;
using InventoryManagement.UI.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Customer
{
    public class CustomerContoller : IController<CustomerControl>
    {
        public CustomerContoller(CustomerControl UIControl) : base(UIControl)
        {

        }

        public void Initialize(bool reset = true)
        {
            if (reset)
            {
                ResetTable();
            }
            var customers = HTTPService.GET<List<CustomerGet>>("customers");
            if (customers == null)
                return;

            InitializeTable(customers);
            InitializeAutoSearchBox(customers);
        }

        public void OpenForm_AddCustomer()
        {
            Form_AddCustomer addCustomer = new Form_AddCustomer();
            var result = addCustomer.ShowDialog();
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Customer added successfully !");
                //Refresh Table
                return;
            }
            else if (result == DialogResult.No)
            {
                DialogResult retry = MessageBox.Show("Customer could not be added. Do you want to try again?", "Failed", MessageBoxButtons.YesNo);
                if (retry == DialogResult.Yes)
                    OpenForm_AddCustomer();
            }
        }

        public void OpenForm_EditCustomer()
        {
            var customerPost = new CustomerPost();
            var customerId = Convert.ToInt32(GetTable().CurrentRow.Cells["CustomerTable_ID"].Value);
            Form_editCustomer editCustomer = new Form_editCustomer(customerId);
            var result = editCustomer.ShowDialog();

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Customer updated successfully !");
                //Refresh Table
                return;
            }
            else if (result == DialogResult.No)
            {
                DialogResult retry = MessageBox.Show("Customer could not be updated. Do you want to try again?", "Failed", MessageBoxButtons.YesNo);
                if (retry == DialogResult.Yes)
                    OpenForm_EditCustomer();
            }
        }

        public void UpdateTableByCustomerName(string name)
        {
            var Table = GetTable();
            foreach  (DataGridViewRow row in Table.Rows)
            {
                bool visible = false;
                var customerName = row.Cells["CustomerTable_Name"].Value.ToString().ToLower();
                if (customerName.StartsWith(name.ToLower()))
                    visible = true;

                row.Visible = visible;
            }
            return;
        }
        private void InitializeTable(List<CustomerGet> customers)
        {
            foreach (var customer in customers)
                AddCustomerToTable(customer);
        }

        private void AddCustomerToTable(CustomerGet customer)
        {
            var Table = GetTable();
            int Index = Table.Rows.Add();
            DataGridViewRow NewRow = Table.Rows[Index];
            NewRow.Cells["CustomerTable_ID"].Value = customer.ID;
            NewRow.Cells["CustomerTable_Name"].Value = customer.Name;
            NewRow.Cells["CustomerTable_EmailId"].Value = customer.Email;
            NewRow.Cells["CustomerTable_MobileNumber"].Value = customer.MobileNumber;
            NewRow.Cells["CustomerTable_PendingAmount"].Value = customer.PendingAmount;
        }

        private void InitializeAutoSearchBox(List<CustomerGet> customers)
        {
            var searchBox = m_UIControl.tb_searchCustomer;
            searchBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (var customer in customers)
                collection.Add(customer.Name);

            searchBox.AutoCompleteCustomSource = collection;
        }
        private void RefreshTable()
        {
            GetTable().Refresh();
        }

        private void ResetTable()
        {
            var Table = GetTable();
            Table.Rows.Clear();
            Table.Refresh();
        }

        private DataGridView GetTable()
        {
            return m_UIControl.customerDataView;
        }
        protected override void RegisterEvents()
        {

        }
    }
}
