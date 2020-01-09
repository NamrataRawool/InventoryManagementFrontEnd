using InventoryManagement.Broadcaster;
using InventoryManagement.Events.Common;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Vendor;
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
        { }

        public void AddNewVendor()
        {
            VendorPost vendor = new VendorPost();
            vendor.CompanyName = m_UIControl.tb_companyName.Text;
            vendor.Address = m_UIControl.tb_address.Text;
            vendor.Email = m_UIControl.tb_email.Text;
            vendor.MobileNumber = m_UIControl.tb_mobileNumber.Text;
            vendor.City = m_UIControl.tb_city.Text;
            vendor.State = m_UIControl.tb_state.Text;
            var vendorGet = DataService.Get().GetVendorDataController().Post(vendor);
            if (vendorGet != null)
            {
                MessageBox.Show("Vendor Added Successfully");
                ResetTextBoxes();
            }

            Event_NewEntryAdded e = new Event_NewEntryAdded(DBEntityType.VENDOR, vendorGet.ID);
            EventBroadcaster.Get().BroadcastEvent(e);

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
