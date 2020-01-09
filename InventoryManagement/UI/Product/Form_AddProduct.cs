using InventoryManagement.Controllers.Product;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
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
    public partial class Form_AddProduct : Form
    {

        FormController_AddProduct m_Controller;

        public Form_AddProduct()
        {
            InitializeComponent();

            m_Controller = new FormController_AddProduct(this);

            cb_Category.DataSource = GetCategories();
        }

        private List<string> GetCategories()
        {
            var categories = DataService.Get().GetCategoryDataController().GetAll();
            var categoryDataSource = new List<string>();
            foreach (var category in categories)
            {
                categoryDataSource.Add(category.Name);
            }
            return categoryDataSource;
        }

        private void ResetAll()
        {
            tb_Name.Text = string.Empty;
            tb_Barcode.Text = string.Empty;
            tb_Description.Text = string.Empty;
            tb_RetailPrice.Text = string.Empty;
            tb_WholeSalePrice.Text = string.Empty;
            cb_Category.Text = string.Empty;
            pictureBox_Image.Image = null;
            tb_CGST.Text = string.Empty;
            tb_SGST.Text = string.Empty;
            tb_Discount.Text = string.Empty;
        }

        private void btn_ResetProduct_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void btn_saveProduct_Click(object sender, EventArgs e)
        {
            bool result = m_Controller.AddNewProduct();
            if (!result)
            {
                // TODO: raise UI warning
                return;
            }

            ResetAll();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ChangeProductImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult dialogResult = dialog.ShowDialog();
            if (dialogResult != DialogResult.OK)
                return;

            string imagePath = dialog.FileName;
            pictureBox_Image.Image = Image.FromFile(imagePath);
            pictureBox_Image.Tag = imagePath;
        }
    }
}
