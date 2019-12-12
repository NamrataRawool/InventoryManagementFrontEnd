using InventoryManagement.UI.Product;
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
            homeControl1.BringToFront();
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            homeControl1.BringToFront();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            AddProduct add = new AddProduct();
            add.ShowDialog();
        }

        private void btn_Home_Click_1(object sender, EventArgs e)
        {

        }
    }
}
