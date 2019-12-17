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

namespace InventoryManagement.UI.UserControls
{
    public partial class TransactionControl : UserControl
    {
        List<BillRowEntry> billingItems = new List<BillRowEntry>
        {
            new BillRowEntry()
            {
                ProductName = "Test",
                Discount =0,
                Price = 0,
                Quantity =0
            }
        };

        public TransactionControl()
        {
            InitializeComponent();
            billDataView.DataSource = billingItems;
        }

    }
}
