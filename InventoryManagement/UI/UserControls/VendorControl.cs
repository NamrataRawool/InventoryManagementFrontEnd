using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.Controllers;
using InventoryManagement.Controllers.Vendor;

namespace InventoryManagement.UI.UserControls
{
    public partial class VendorControl : UserControl
    {
        VendorController m_Controller;

        public VendorControl()
        {
            InitializeComponent();
            m_Controller = new VendorController(this);
        }

        private void VendorControl_Load(object sender, EventArgs e)
        {    
            m_Controller.Initialize();
        }

        private void btn_editVendor_Click(object sender, EventArgs e)
        {
            m_Controller.OpenForm_EditVendor();
        }

        private void btn_addVendor_Click(object sender, EventArgs e)
        {
            m_Controller.OpenForm_AddVendor();
        }

        private void btn_searchVendor_Click(object sender, EventArgs e)
        {
            m_Controller.UpdateTableByCompanyName(tb_searchVendors.Text);
        }

        private void tb_searchVendors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                m_Controller.UpdateTableByCompanyName(tb_searchVendors.Text);
            }
        }

        private void VendorsDataView_DoubleClick(object sender, EventArgs e)
        {
            m_Controller.OpenForm_EditVendor();
        }

    }
}
