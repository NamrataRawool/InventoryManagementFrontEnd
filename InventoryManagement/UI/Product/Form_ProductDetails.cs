using InventoryManagement.Controllers.Product;
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

    /*
     *  - Edit the product Details
     *  - Update the Stock Values
     *  - Stock History will be available
     */

    public partial class Form_ProductDetails : Form
    {

        private FormController_ProductDetails m_Controller;

        public Form_ProductDetails(int productID)
        {
            InitializeComponent();

            m_Controller = new FormController_ProductDetails(productID, this);
        }

        // update the image
        private void btn_ChangeProductImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult dialogResult = dialog.ShowDialog();
            if (dialogResult != DialogResult.OK)
                return;

            string imagePath = dialog.FileName;
            pictureBox_ProductImage.Image = Image.FromFile(imagePath);
            pictureBox_ProductImage.Tag = imagePath;
        }

        private void Button_UpdateProductDetails_Click(object sender, EventArgs e)
        {
            m_Controller.UpdateProductDetails();
        }
    }
}
