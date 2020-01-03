using InventoryManagement.Models;
using InventoryManagement.Services.HTTP;
using InventoryManagement.UI.UserControls;
using InventoryManagement.UI.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Vendor
{
    public class VendorController : IController<VendorControl>
    {
        public VendorController(VendorControl UIControl) : base(UIControl)
        {

        }
        public void Initialize(bool reset = true)
        {
            if (reset)
            {
                ResetTable();
            }

            var vendors = HTTPService.GET<List<VendorGet>>("vendors");
            if (vendors == null)
                return;

            InitializeTable(vendors);
            InitializeAutoSearchBox(vendors);
        }
        public void OpenForm_AddVendor()
        {
            Form_AddVendor addVendor = new Form_AddVendor();
            addVendor.ShowDialog();
        }

        public void OpenForm_EditVendor()
        {
            var Table = GetTable();

            var rows = Table.SelectedRows;
            if (rows.Count < 0)
                return;

            int selectedRowIndex = Table.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Table.Rows[selectedRowIndex];
            int vendorId = int.Parse(selectedRow.Cells["VendorTable_Id"].Value.ToString());
            Form_EditVendor editVendor = new Form_EditVendor(vendorId);
            editVendor.ShowDialog();
            //TODO: REfresh
            Initialize();
        }

        public void SearchVendor(string name)
        {
            var Table = GetTable();
            Table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CurrencyManager currencyManager = (CurrencyManager)m_UIControl.BindingContext[Table.DataSource];
            currencyManager.SuspendBinding();
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in Table.Rows)
                {
                    int rowIndex = row.Index;
                    if (row.Cells["VendorTable_CompanyName"].Value != null && row.Cells["VendorTable_CompanyName"].Value.ToString().ToLower().StartsWith(name.ToLower()))
                    {
                        Table.Rows[rowIndex].Visible = true;
                        Table.FirstDisplayedScrollingRowIndex = rowIndex;
                        valueResult = true;
                    }
                    else
                    {
                        Table.Rows[rowIndex].Visible = false;
                    }

                }
                currencyManager.ResumeBinding();
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + name);
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
        public void RefreshTable()
        {
            GetTable().Refresh();
        }
        public void ResetTable()
        {
            var Table = GetTable();
            Table.Rows.Clear();
            Table.Refresh();
        }

        private void InitializeTable(List<VendorGet> vendors)
        {
            foreach (var vendor in vendors)
                AddVendorToTable(vendor);
        }
        private void InitializeAutoSearchBox(List<VendorGet> vendors)
        {
            var searchBox = m_UIControl.tb_searchVendors;
            searchBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (var vendor in vendors)
                collection.Add(vendor.CompanyName);

            searchBox.AutoCompleteCustomSource = collection;
        }

        private void AddVendorToTable(VendorGet vendor)
        {
            var Table = GetTable();
            int Index = Table.Rows.Add();
            DataGridViewRow NewRow = Table.Rows[Index];
            NewRow.Cells["VendorTable_Id"].Value = vendor.ID;
            NewRow.Cells["VendorTable_CompanyName"].Value = vendor.CompanyName;
            NewRow.Cells["VendorTable_Email"].Value = vendor.Email;
            NewRow.Cells["VendorTable_MobileNumber"].Value = vendor.MobileNumber;
            NewRow.Cells["VendorTable_Address"].Value = vendor.Address;
        }
        private DataGridView GetTable()
        {
            return m_UIControl.VendorsDataView;
        }

        protected override void RegisterEvents()
        {

        }
    }
}
