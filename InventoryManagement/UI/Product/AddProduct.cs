using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.UI.Product
{
    public partial class form_ProductDetails : Form
    {
        public form_ProductDetails()
        {
            InitializeComponent();
            cb_Category.DataSource = new List<string>() { "c1", "c2", "c3", "category4", "category5" };
        }

        private void btn_ResetProduct_Click(object sender, EventArgs e)
        {
            tb_Name.Text = string.Empty;
            tb_description.Text = string.Empty;
            tb_retailPrice.Text = string.Empty;
            tb_wholeSalePrice.Text = string.Empty;
        }

        private void btn_saveProduct_Click(object sender, EventArgs e)
        {

        }

        private void btn_browseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Files",

                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tb_imageName.Text = openFileDialog.FileName;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
