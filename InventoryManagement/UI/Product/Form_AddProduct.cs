using InventoryManagement.Controllers.Product;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Category;
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

            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            var categories = DataService.GetCategoryDataController().GetAll();

            foreach(var category in categories)
                cb_Category.Items.Add(category.Name);

            cb_Category.SelectedIndex = 0;
        }

        private void btn_ResetProduct_Click(object sender, EventArgs e)
        {
            m_Controller.ResetAll();
        }

        private void btn_saveProduct_Click(object sender, EventArgs e)
        {
            bool result = m_Controller.AddNewProduct();
            if (!result)
            {
                // TODO: raise UI warning
                return;
            }

            m_Controller.ResetAll();
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

        private void btn_AddNewCategory_Click(object sender, EventArgs e)
        {
            Form_AddCategory form = new Form_AddCategory();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            CategoryGet category = form.GetAddedCategory();
            cb_Category.Text = category.Name;
        }

        public ProductGet GetProduct() { return m_Controller.GetCustomer(); }
    }
}
