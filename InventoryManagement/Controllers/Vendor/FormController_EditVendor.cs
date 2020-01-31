using InventoryManagement.Broadcaster;
using InventoryManagement.Events.Common;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.Services.Misc.Assert;
using InventoryManagement.UI.Vendor;
using InventoryManagement.Utilities;
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
            if (!ValidateVendorDetails())
                return;
            VendorPost vendorPost = new VendorPost();
            vendorPost.ID = int.Parse(m_UIControl.tb_vendorId.Text.Trim());
            vendorPost.CompanyName = m_UIControl.tb_companyName.Text.Trim();
            vendorPost.Address = m_UIControl.tb_address.Text.Trim();
            vendorPost.Email = m_UIControl.tb_email.Text.Trim();
            vendorPost.MobileNumber = m_UIControl.tb_mobileNumber.Text.Trim();
            vendorPost.City = m_UIControl.tb_city.Text.Trim();
            vendorPost.State = m_UIControl.tb_state.Text.Trim();

            var vendorGet = DataService.GetVendorDataController().Put(vendorPost);
            if (vendorGet == null)
            {
                Assert.Do("Failed to edit vendor");
                return;
            }
            MessageBox.Show("Vendor Updated Successfully");
            ResetTextBoxes();
            m_UIControl.DialogResult = DialogResult.OK;

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

        private bool ValidateVendorDetails()
        {
            m_UIControl.lbl_valiadationError.Text = string.Empty;
            var companyName = m_UIControl.tb_companyName.Text.Trim();
            var address = m_UIControl.tb_address.Text.Trim();
            var email = m_UIControl.tb_email.Text.Trim();
            var mobileNumber = m_UIControl.tb_mobileNumber.Text.Trim();
            var city = m_UIControl.tb_city.Text.Trim();
            var state = m_UIControl.tb_state.Text.Trim();

            if (string.IsNullOrEmpty(companyName))
            {
                m_UIControl.lbl_valiadationError.Text = "Company name cannot be empty";
                return false;
            }
            if (!Validator.IsValidAlphaNumeric(companyName))
            {
                m_UIControl.lbl_valiadationError.Text = "Company name not valid!";
                return false;
            }
            if (!string.IsNullOrEmpty(email))
            {
                if (!Validator.IsValidEmail(email))
                {
                    m_UIControl.lbl_valiadationError.Text = "Email ID not valid!";
                    return false;
                }
            }
            if (!string.IsNullOrEmpty(mobileNumber))
            {
                if (!Validator.IsValidMobileNumber(mobileNumber))
                {
                    m_UIControl.lbl_valiadationError.Text = "Mobile number not valid!";
                    return false;
                }
            }
            if (!string.IsNullOrEmpty(city))
            {
                if (!Validator.IsValidString(city))
                {
                    m_UIControl.lbl_valiadationError.Text = "City not valid!";
                    return false;
                }
            }
            if (!string.IsNullOrEmpty(state))
            {
                if (!Validator.IsValidString(state))
                {
                    m_UIControl.lbl_valiadationError.Text = "State not valid!";
                    return false;
                }
            }
            return true;
        }
        protected override void RegisterEvents()
        {
        }

    }
}
