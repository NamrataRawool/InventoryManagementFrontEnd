using InventoryManagement.Controllers.Purchase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.UI.Purchase
{
    public partial class Form_ViewPuchaseBill : Form
    {
        FormController_ViewPurchaseBill m_controller;
        public Form_ViewPuchaseBill()
        {
            InitializeComponent();
            m_controller = new FormController_ViewPurchaseBill(this);
        }

        private void btn_SavePurchase_Click(object sender, EventArgs e)
        {

        }
    }
}
