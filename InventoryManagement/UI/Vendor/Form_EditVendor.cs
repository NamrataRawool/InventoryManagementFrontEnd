using InventoryManagement.Controllers.Vendor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.UI.Vendor
{
    public partial class Form_EditVendor : Form
    {
        FormController_EditVendor m_controller;
        public Form_EditVendor(int vendorId)
        {
            InitializeComponent();
            m_controller = new FormController_EditVendor(vendorId, this);
        }

        private void btn_updateVendor_Click(object sender, EventArgs e)
        {
            m_controller.UpdateVendor();
        }
    }
}
