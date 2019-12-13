using InventoryManagement.Models;
using InventoryManagement.Services.HTTP;
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
            homeControl.BringToFront();
            ChangeButtonBackColor(btn_Home);
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            homeControl.BringToFront();
            ChangeButtonBackColor(btn_Home);
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            productControl.BringToFront();
            ChangeButtonBackColor(btn_Product);
        }
        private void btn_Category_Click(object sender, EventArgs e)
        {
            categoryControl.BringToFront();
            ChangeButtonBackColor(btn_Category);
        }

        private void btn_Transaction_Click(object sender, EventArgs e)
        {
            transactionControl.BringToFront();
            ChangeButtonBackColor(btn_Transaction);
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            customerControl.BringToFront();
            ChangeButtonBackColor(btn_Customer);
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            stockControl.BringToFront();
            ChangeButtonBackColor(btn_Stock);
        }

        private void ChangeButtonBackColor(Button button)
        {
            var buttons = new List<Button>() { btn_Home, btn_Product, btn_Category, btn_Customer, btn_Transaction, btn_Stock };
            foreach (Button btn in buttons)
            {
                if (button.Equals(btn))
                {
                    button.BackColor = Color.FromArgb(246, 247, 251);
                    button.ForeColor = Color.Black;
                }
                else
                {
                    btn.BackColor = Color.FromArgb(24, 24, 36);
                    btn.ForeColor = Color.White;
                }
            }
        }
    }
}
