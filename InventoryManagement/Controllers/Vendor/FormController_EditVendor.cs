using InventoryManagement.Models;
using InventoryManagement.Services.HTTP;
using InventoryManagement.UI.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            VendorPost vendor = new VendorPost();
            vendor.ID = int.Parse(m_UIControl.tb_vendorId.Text);
            vendor.CompanyName = m_UIControl.tb_companyName.Text;
            vendor.Address = m_UIControl.tb_address.Text;
            vendor.Email = m_UIControl.tb_email.Text;
            vendor.MobileNumber = m_UIControl.tb_mobileNumber.Text;
            vendor.City = m_UIControl.tb_city.Text;
            vendor.State = m_UIControl.tb_state.Text;
            var vendorPost = HTTPService.POST<VendorGet, VendorPost>("vendor", vendor);
            if (vendorPost != null)
            {
                MessageBox.Show("Vendor Updated Successfully");
                ResetTextBoxes();
            }
        }

        private void InitializeVendorDetails(int vendorId)
        {
            var vendor = HTTPService.GET<VendorGet>("vendor/" + vendorId);
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
