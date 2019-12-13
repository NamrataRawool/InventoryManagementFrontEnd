using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.Services.HTTP;
using InventoryManagement.Models;

namespace InventoryManagement.UserControls
{
    public partial class CustomerControl : UserControl
    {
        public CustomerControl()
        {
            InitializeComponent();
            customerDataView.DataSource = GetCustomers();
        }
        private List<CustomerGet> GetCustomers()
        {
            var customers = HTTPService.GET<List<CustomerGet>>("customers");
            var customerDataSource = new List<CustomerGet>();
            foreach (var customer in customers)
            {
                customerDataSource.Add(customer);
            }
            return customerDataSource;
        }
    }
}
