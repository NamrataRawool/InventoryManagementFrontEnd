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

namespace InventoryManagement.UI.UserControls
{
    public partial class TransactionControl : UserControl
    {
        List<Bill> billingItems = new List<Bill> { new Bill()
        {
            ProductName = "",
            Discount =0,
            Price = 0,
            Quantity =0
        } };
        public TransactionControl()
        {
            InitializeComponent();
            billDataView.DataSource = billingItems;
        }

    }
}
