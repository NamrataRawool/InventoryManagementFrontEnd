using InventoryManagement.Models;
using InventoryManagement.Services.HTTP;
using InventoryManagement.UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.UI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            UpdateSidePanel(btn_Home);
            productControl.BringToFront();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            UpdateSidePanel(btn_Home);
            homeControl.BringToFront();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            UpdateSidePanel(btn_Product);
            productControl.BringToFront();
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            UpdateSidePanel(btn_Category);
            categoryControl.BringToFront();
        }
        private void btn_Transaction_Click(object sender, EventArgs e)
        {
            UpdateSidePanel(btn_Transaction);
            transactionControl.BringToFront();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            UpdateSidePanel(btn_Customer);
            customerControl.BringToFront();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            UpdateSidePanel(btn_Stock);
            stockControl.BringToFront();
        }

        private void btn_AboutUs_Click(object sender, EventArgs e)
        {
            UpdateSidePanel(btn_AboutUs);
        }

        public void UpdateSidePanel(Control control)
        {
            SidePanel.Height    = control.Height;
            SidePanel.Top       = control.Top;
        }

    }
}
