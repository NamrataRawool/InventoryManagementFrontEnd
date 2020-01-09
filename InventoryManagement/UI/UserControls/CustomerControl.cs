using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.Services.HTTP;
using InventoryManagement.Models;
using InventoryManagement.UI.Customer;
using InventoryManagement.Controllers.Customer;

namespace InventoryManagement.UI.UserControls
{
    public partial class CustomerControl : UserControl
    {
        CustomerContoller m_controller;
        public CustomerControl()
        {
            InitializeComponent();
            m_controller = new CustomerContoller(this);
        }
        private void CustomerControl_Load(object sender, EventArgs e)
        {
            m_controller.Initialize();
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            m_controller.OpenForm_AddCustomer();

        }

        private void btn_editCustomer_Click(object sender, EventArgs e)
        {
            m_controller.OpenForm_EditCustomer();     
        }

        private void btn_searchCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
