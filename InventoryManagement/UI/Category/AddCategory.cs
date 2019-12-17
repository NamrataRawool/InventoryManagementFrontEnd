using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.UI.Category
{
    public partial class form_categoryDetails : Form
    {
        public form_categoryDetails()
        {
            InitializeComponent();
        }

        private void btn_ResetCategory_Click(object sender, EventArgs e)
        {
            tb_categoryName.Text = string.Empty;
            tb_categoryDescription.Text = string.Empty;
            tb_categoryDiscount.Text = string.Empty;
            tb_categorySgst.Text = string.Empty;
            tb_categoryCgst.Text = string.Empty;
        }

        private void btn_cancelCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_saveCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
