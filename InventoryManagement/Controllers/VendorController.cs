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

namespace InventoryManagement.Controllers
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
            Form_EditVendor editVendor = new Form_EditVendor();
            editVendor.ShowDialog();
        }

        protected override void RegisterEvents()
        {

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
    }
}
