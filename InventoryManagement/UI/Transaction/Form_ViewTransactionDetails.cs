using InventoryManagement.Controllers.Transaction;
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
    public partial class Form_ViewTransactionDetails : Form
    {
        FormController_ViewTransactionDetails m_controller;
        public Form_ViewTransactionDetails(int transasctionId)
        {
            InitializeComponent();
            m_controller = new FormController_ViewTransactionDetails(transasctionId, this);
        }
    }
}
