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
using InventoryManagement.Services.HTTP;

namespace InventoryManagement.UserControls
{
    public partial class CategoryControl : UserControl
    {
        public CategoryControl()
        {
            InitializeComponent();
            categoryDataView.DataSource = HTTPService.GET<List<CategoryGet>>("categories");
        }

        private void btn_editCategory_Click(object sender, EventArgs e)
        {

        }

        private void btn_addCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
