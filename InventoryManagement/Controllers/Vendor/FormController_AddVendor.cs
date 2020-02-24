using InventoryManagement.Broadcaster;
using InventoryManagement.Events.Common;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.Services.Misc.Assert;
using InventoryManagement.UI.Vendor;
using InventoryManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Vendor
{
    public class FormController_AddVendor : IController<Form_AddVendor>
    {
        public FormController_AddVendor(Form_AddVendor UIcontrol) : base(UIcontrol)
        {
        }

        public VendorGet AddNewVendor()
        {
            if (!ValidateVendorDetails())
                return null;

            VendorPost vendor = new VendorPost();
            vendor.CompanyName = m_UIControl.tb_companyName.Text.Trim();
            vendor.Address = m_UIControl.tb_address.Text.Trim();
            vendor.Email = m_UIControl.tb_email.Text.Trim();
            vendor.MobileNumber = m_UIControl.tb_mobileNumber.Text.Trim();
            vendor.City = m_UIControl.tb_city.Text.Trim();
            vendor.State = m_UIControl.tb_state.Text.Trim();

            var vendorGet = DataService.GetVendorDataController().Post(vendor);
            if (vendorGet == null)
            {
                Assert.Do("Failed to add vendor");
                return null;
            }

            MessageBox.Show("Vendor Added Successfully");
            ResetTextBoxes();

            Event_NewEntryAdded e = new Event_NewEntryAdded(DBEntityType.VENDOR, vendorGet.ID);
            EventBroadcaster.Get().BroadcastEvent(e);

            if (!m_UIControl.checkBox_AddAnotherVendor.Checked)
            {
                m_UIControl.DialogResult = DialogResult.OK;
                m_UIControl.Close();
            }

            return vendorGet;
        }

        private bool ValidateVendorDetails()
        {
            m_UIControl.lbl_ValidationError.Text = string.Empty;
            var companyName = m_UIControl.tb_companyName.Text.Trim();
            var address = m_UIControl.tb_address.Text.Trim();
            var email = m_UIControl.tb_email.Text.Trim();
            var mobileNumber = m_UIControl.tb_mobileNumber.Text.Trim();
            var city = m_UIControl.tb_city.Text.Trim();
            var state = m_UIControl.tb_state.Text.Trim();

            if (string.IsNullOrEmpty(companyName))
            {
                m_UIControl.lbl_ValidationError.Text = "Company name cannot be empty!";
                return false;
            }
            if (!Validator.IsValidAlphaNumeric(companyName))
            {
                m_UIControl.lbl_ValidationError.Text = "Company name not valid!";
                return false;
            }
            if (!string.IsNullOrEmpty(email))
            {
                if (!Validator.IsValidEmail(email))
                {
                    m_UIControl.lbl_ValidationError.Text = "Email ID not valid!";
                    return false;
                }
            }
            if (!string.IsNullOrEmpty(mobileNumber))
            {
                if (!Validator.IsValidMobileNumber(mobileNumber))
                {
                    m_UIControl.lbl_ValidationError.Text = "Mobile number not valid!";
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(city))
            {
                if (!Validator.IsValidString(city))
                {
                    m_UIControl.lbl_ValidationError.Text = "City not valid!";
                    return false;
                }
            }
            if (!string.IsNullOrEmpty(state))
            {
                if (!Validator.IsValidString(state))
                {
                    m_UIControl.lbl_ValidationError.Text = "State not valid!";
                    return false;
                }
            }
            return true;
        }
        private void ResetTextBoxes()
        {
            m_UIControl.tb_companyName.Text = string.Empty;
            m_UIControl.tb_address.Text = string.Empty;
            m_UIControl.tb_email.Text = string.Empty;
            m_UIControl.tb_mobileNumber.Text = string.Empty;
            m_UIControl.tb_city.Text = string.Empty;
            m_UIControl.tb_state.Text = string.Empty;
        }

        protected override void RegisterEvents()
        {

        }

    }
}
