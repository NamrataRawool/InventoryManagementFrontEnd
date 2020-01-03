using InventoryManagement.Controllers.Vendor;
using InventoryManagement.Models;
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
    public partial class Form_AddVendor : Form
    {
        FormController_AddVendor m_controller;
        public Form_AddVendor()
        {
            InitializeComponent();
            m_controller = new FormController_AddVendor(this);
        }

        private void btn_addVendor_Click(object sender, EventArgs e)
        {
            m_controller.AddNewVendor();
        }
    }
}
