using InventoryManagement.Controllers.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.UI.Customer
{
    public partial class Form_AddCustomer : Form
    {
        FormController_AddCustomer m_controller;
        public Form_AddCustomer()
        {
            InitializeComponent();
            m_controller = new FormController_AddCustomer(this);
        }

        private void btn_ResetCustomer_Click(object sender, EventArgs e)
        {
            m_controller.ResetTextBoxes();
        }

        private void btn_saveCustomer_Click(object sender, EventArgs e)
        {
            m_controller.SaveCustomer();
            Close();
        }
    }
}
