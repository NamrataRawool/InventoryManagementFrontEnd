using InventoryManagement.Models;
using InventoryManagement.Services.HTTP;
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
            cb_Category.DataSource = GetCategories();
        }

        private List<string> GetCategories()
        {
            var categories = HTTPService.GET<List<CategoryGet>>("categories");
            var categoryDataSource = new List<string>();
            foreach (var category in categories)
            {
                categoryDataSource.Add(category.Name);
            }
            return categoryDataSource;
        }
        private void btn_ResetProduct_Click(object sender, EventArgs e)
        {
            tb_Name.Text = string.Empty;
            tb_description.Text = string.Empty;
            tb_retailPrice.Text = string.Empty;
            tb_wholeSalePrice.Text = string.Empty;
            cb_Category.Text = string.Empty;
            tb_imageName.Text = string.Empty;
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
