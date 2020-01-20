using InventoryManagement.EventHandlers.Vendor;
using InventoryManagement.Events;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
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
            SetEventHandler(new EventHandler_Vendor(this));
        }

        public void Initialize(bool reset = true)
        {
            if (reset)
            {
                ResetTable();
            }

            var vendors = DataService.GetVendorDataController().GetAll();
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

        public void UpdateTableByCompanyName(string name)
        {
            var Table = GetTable();

            foreach (DataGridViewRow row in Table.Rows)
            {
                bool visible = false;
                var companyName = row.Cells["VendorTable_CompanyName"].Value.ToString().ToLower();
                if (companyName.StartsWith(name.ToLower()))
                    visible = true;

                row.Visible = visible;
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

        public void AddProductToAutoSearchBox(string vendorName)
        {
            var searchBox = m_UIControl.tb_searchVendors;
            searchBox.AutoCompleteCustomSource.Add(vendorName);
        }

        public void AddVendorToTable(VendorGet vendor)
        {
            var Table = GetTable();
            int Index = Table.Rows.Add();
            DataGridViewRow NewRow = Table.Rows[Index];
            NewRow.Cells["VendorTable_Id"].Value            = vendor.ID;
            NewRow.Cells["VendorTable_CompanyName"].Value   = vendor.CompanyName;
            NewRow.Cells["VendorTable_Email"].Value         = vendor.Email;
            NewRow.Cells["VendorTable_MobileNumber"].Value  = vendor.MobileNumber;
            NewRow.Cells["VendorTable_Address"].Value       = vendor.Address;
        }

        public void UpdateTableEntry_Vendor(VendorGet vendor)
        {
            var table = GetTable();

            for (int i = 0; i < table.Rows.Count; ++i)
            {
                DataGridViewRow row = table.Rows[i];

                int id = int.Parse(row.Cells["VendorTable_Id"].Value.ToString());
                if (vendor.ID == id)
                {
                    row.Cells["VendorTable_Id"].Value           = vendor.ID;
                    row.Cells["VendorTable_CompanyName"].Value  = vendor.CompanyName;
                    row.Cells["VendorTable_Email"].Value        = vendor.Email;
                    row.Cells["VendorTable_MobileNumber"].Value = vendor.MobileNumber;
                    row.Cells["VendorTable_Address"].Value      = vendor.Address;
                    return;
                }
            }
        }

        private DataGridView GetTable()
        {
            return m_UIControl.VendorsDataView;
        }

        protected override void RegisterEvents()
        {
            RegisterEvent(EventType.NewEntryAdded);
            RegisterEvent(EventType.EntryUpdated);
        }
    }
}
