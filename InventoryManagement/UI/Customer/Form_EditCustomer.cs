﻿using System;
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
        public Form_editCustomer()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_resetEditCustomer_Click(object sender, EventArgs e)
        {
            tb_editCustomerName.Text = string.Empty;
            tb_editCustomerMobile.Text = string.Empty;
            tb_editCustomerEmail.Text = string.Empty;
            tb_editCustomerTotalAmount.Text = string.Empty;
            tb_editCustomerPendingAmount.Text = string.Empty;
        }

        private void btn_saveEditCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}