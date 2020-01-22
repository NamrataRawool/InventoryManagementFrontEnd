using InventoryManagement.Controllers.Category;
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
    public partial class Form_EditCategory : Form
    {

        private FormController_EditCategory m_Controller;

        public Form_EditCategory(int categoryID)
        {
            InitializeComponent();

            m_Controller = new FormController_EditCategory(categoryID, this);
        }

        private void btn_UpdateCategory_Click(object sender, EventArgs e)
        {
            m_Controller.UpdateCategory();
        }

        private void btn_resetCategory_Click(object sender, EventArgs e)
        {
            tb_ID.Text = string.Empty;
            tb_categoryName.Text = string.Empty;
            tb_categoryDescription.Text = string.Empty;
        }
    }
}
