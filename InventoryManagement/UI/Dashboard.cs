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
            SidePanel.Height = btn_Home.Height;
            homeControl.BringToFront();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Home.Height;
            SidePanel.Top = btn_Home.Top;
            homeControl.BringToFront();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Product.Height;
            SidePanel.Top = btn_Product.Top;
            productControl.BringToFront();
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Category.Height;
            SidePanel.Top = btn_Category.Top;
            categoryControl.BringToFront();
        }
        private void btn_Transaction_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Transaction.Height;
            SidePanel.Top = btn_Transaction.Top;
            transactionControl.BringToFront();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Customer.Height;
            SidePanel.Top = btn_Customer.Top;
            customerControl.BringToFront();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Stock.Height;
            SidePanel.Top = btn_Stock.Top;
            stockControl.BringToFront();
        }

        private void btn_AboutUs_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_AboutUs.Height;
            SidePanel.Top = btn_AboutUs.Top;
        }
    }
}
