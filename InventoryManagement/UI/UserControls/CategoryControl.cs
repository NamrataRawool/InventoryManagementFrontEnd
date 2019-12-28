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
using InventoryManagement.Services.HTTP;
using InventoryManagement.UI.Category;

namespace InventoryManagement.UI.UserControls
{
    public partial class CategoryControl : UserControl
    {
        public CategoryControl()
        {
            InitializeComponent();         
        }

        private void CategoryControl_Load(object sender, EventArgs e)
        {
            categoryDataView.DataSource = HTTPService.GET<List<CategoryGet>>("categories");
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
                editCategory.tb_categoryDiscount.Text = selectedRow.Cells["Discount"].Value.ToString();
                editCategory.tb_categorySgst.Text = selectedRow.Cells["CGST"].Value.ToString();
                editCategory.tb_categoryCgst.Text = selectedRow.Cells["SGST"].Value.ToString();
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
