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
            form_categoryDetails editCategory = new form_categoryDetails();
            var rows = categoryDataView.SelectedRows;
            if (rows.Count > 0)
            {
                int selectedRowIndex = categoryDataView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = categoryDataView.Rows[selectedRowIndex];
                editCategory.tb_categoryName.Text = selectedRow.Cells["Name"].Value.ToString(); ;
                editCategory.tb_categoryDescription.Text = selectedRow.Cells["Description"].Value.ToString();
            }
            editCategory.ShowDialog();
        }

        private void btn_addCategory_Click(object sender, EventArgs e)
        {
            form_categoryDetails addCategory = new form_categoryDetails();
            addCategory.ShowDialog();
        }

    }
}
