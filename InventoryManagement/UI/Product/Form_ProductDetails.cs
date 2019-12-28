using InventoryManagement.Controllers.Product;
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

    }
}
