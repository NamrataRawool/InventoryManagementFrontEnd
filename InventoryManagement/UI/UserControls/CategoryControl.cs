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
using InventoryManagement.UI.Category;
using InventoryManagement.Services.Data;
using InventoryManagement.Controllers.Category;

namespace InventoryManagement.UI.UserControls
{
    public partial class CategoryControl : UserControl
    {

        CategoryController m_Controller;

        public CategoryControl()
        {
            InitializeComponent();
        }

        private void CategoryControl_Load(object sender, EventArgs e)
        {
            m_Controller = new CategoryController(this);
            m_Controller.Initialize();
        }

        private void btn_editCategory_Click(object sender, EventArgs e)
        {
            m_Controller.OpenForm_EditCategory();
        }

        private void btn_addCategory_Click(object sender, EventArgs e)
        {
            m_Controller.OpenForm_AddCategory();
        }

        private void categoryDataView_DoubleClick(object sender, EventArgs e)
        {
            m_Controller.OpenForm_EditCategory();
        }

        private void btn_searchCategory_Click(object sender, EventArgs e)
        {
            m_Controller.UpdateTableByCategoryName(tb_searchCategory.Text.Trim());
        }

        private void tb_searchCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                m_Controller.UpdateTableByCategoryName(tb_searchCategory.Text.Trim());
            }
        }

        private void tb_searchCategory_TextChanged(object sender, EventArgs e)
        {
            m_Controller.UpdateTableByCategoryName(tb_searchCategory.Text.Trim());
        }
    }
}
