using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.Models;
using InventoryManagement.Events;
using InventoryManagement.Broadcaster;
using InventoryManagement.Controllers;

namespace InventoryManagement.UI.UserControls
{
    public partial class TransactionControl : UserControl
    {
        TransactionController m_Controller;

        public TransactionControl()
        {
            m_Controller = new TransactionController(this);

            InitializeComponent();
        }

    }
}
