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
    public partial class Form_editCustomer : Form
    {
        FormController_EditCustomer m_controller;
        public Form_editCustomer(int customerId)
        {
            InitializeComponent();
            m_controller = new FormController_EditCustomer(customerId, this);
        }
        private void Form_editCustomer_Load(object sender, EventArgs e)
        {

        }
        private void btn_resetCustomer_Click(object sender, EventArgs e)
        {
            m_controller.ResetTextBoxes();
        }

        private void btn_updateCustomer_Click(object sender, EventArgs e)
        {
            m_controller.UpdateCustomer();
        }


    }
}
