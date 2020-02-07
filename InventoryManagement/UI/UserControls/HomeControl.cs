using System;
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
    public partial class HomeControl : UserControl
    {
        HomeController m_controller;
        public HomeControl()
        {
            InitializeComponent();
            m_controller = new HomeController(this);
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
          
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_dateTime.Text = DateTime.Now.ToString();
        }
    }
}
