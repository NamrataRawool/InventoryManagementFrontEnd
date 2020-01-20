using InventoryManagement.Broadcaster;
using InventoryManagement.Events.Common;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Vendor;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Vendor
{
    public class FormController_EditVendor : IController<Form_EditVendor>
    {
        public FormController_EditVendor(int vendorId, Form_EditVendor UIControl) : base(UIControl)
        {
            Initialize(vendorId);
        }

        public void Initialize(int vendorId)
        {
            InitializeVendorDetails(vendorId);
        }

        private void ResetTextBoxes()
        {
            m_UIControl.tb_vendorId.Text = string.Empty;
            m_UIControl.tb_companyName.Text = string.Empty;
            m_UIControl.tb_address.Text = string.Empty;
            m_UIControl.tb_email.Text = string.Empty;
            m_UIControl.tb_mobileNumber.Text = string.Empty;
            m_UIControl.tb_city.Text = string.Empty;
            m_UIControl.tb_state.Text = string.Empty;
        }

        public void UpdateVendor()
        {
            VendorPost vendorPost = new VendorPost();
            vendorPost.ID = int.Parse(m_UIControl.tb_vendorId.Text);
            vendorPost.CompanyName = m_UIControl.tb_companyName.Text;
            vendorPost.Address = m_UIControl.tb_address.Text;
            vendorPost.Email = m_UIControl.tb_email.Text;
            vendorPost.MobileNumber = m_UIControl.tb_mobileNumber.Text;
            vendorPost.City = m_UIControl.tb_city.Text;
            vendorPost.State = m_UIControl.tb_state.Text;

            var vendorGet = DataService.GetVendorDataController().Put(vendorPost);
            if (vendorGet != null)
            {
                MessageBox.Show("Vendor Updated Successfully");
                ResetTextBoxes();
            }

            // fire vendor updated event
            Event_EntryUpdated e = new Event_EntryUpdated(DBEntityType.VENDOR, vendorGet.ID);
            EventBroadcaster.Get().BroadcastEvent(e);
        }

        private void InitializeVendorDetails(int vendorId)
        {
            var vendor = DataService.GetVendorDataController().Get(vendorId);
            if (vendor == null)
                return;
            m_UIControl.tb_vendorId.Text = vendor.ID.ToString();
            m_UIControl.tb_companyName.Text = vendor.CompanyName;
            m_UIControl.tb_address.Text = vendor.Address;
            m_UIControl.tb_email.Text = vendor.Email;
            m_UIControl.tb_mobileNumber.Text = vendor.MobileNumber;
            m_UIControl.tb_city.Text = vendor.City;
            m_UIControl.tb_state.Text = vendor.State;
        }

        protected override void RegisterEvents()
        {
        }

    }
}
