﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.Controllers;

namespace InventoryManagement.UI.UserControls
{
    public partial class DashboardControl : UserControl
    {
        DashboardController m_controller;
        public DashboardControl()
        {
            InitializeComponent();
            m_controller = new DashboardController(this);
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_dateTime.Text = DateTime.Now.ToString();
        }

        private void btn_MoreInfo_Transactions_Click(object sender, EventArgs e)
        {

        }

        private void btn_MoreInfo_Purchases_Click(object sender, EventArgs e)
        {

        }

        private void btn_MoreInfo_Customers_Click(object sender, EventArgs e)
        {

        }

        private void btn_MoreInfo_LowStock_Click(object sender, EventArgs e)
        {

        }

        private void btn_MoreInfo_PendingAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
