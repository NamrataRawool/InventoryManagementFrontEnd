using InventoryManagement.UserControls;
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
            //  homeControl.BringToFront();
            productControl.BringToFront();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            homeControl.BringToFront();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            productControl.BringToFront();
        }
        private void btn_Category_Click(object sender, EventArgs e)
        {
            categoryControl.BringToFront();
        }

        private void btn_Transaction_Click(object sender, EventArgs e)
        {
            transactionControl.BringToFront();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            customerControl.BringToFront();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            stockControl.BringToFront();
        }
    }
}
