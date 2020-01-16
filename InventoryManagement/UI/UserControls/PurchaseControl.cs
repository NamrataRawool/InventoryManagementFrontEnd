using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.Controllers.Purchase;

namespace InventoryManagement.UI.UserControls
{
    public partial class PurchaseControl : UserControl
    {
        NewPurchaseController m_newPurchaseController;
        public PurchaseControl()
        {
            InitializeComponent();
            m_newPurchaseController = new NewPurchaseController(this);
        }
        private void PurchaseControl_Load(object sender, EventArgs e)
        {
            m_newPurchaseController.Initialize();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            m_newPurchaseController.ResetUIControls();
        }


    }
}
