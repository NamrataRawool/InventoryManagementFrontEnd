using InventoryManagement.Controllers.Transaction;
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

namespace InventoryManagement.UI.Transaction
{
    public partial class Form_ViewBill : Form
    {
        private FormController_ViewBill m_Controller;

        public Form_ViewBill(TransactionGet transaction)
        {
            InitializeComponent();
            m_Controller = new FormController_ViewBill(transaction, this);
        }


        private void Form_ViewBill_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
