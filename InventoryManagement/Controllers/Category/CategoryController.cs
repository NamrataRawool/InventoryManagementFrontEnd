using InventoryManagement.EventHandlers.Category;
using InventoryManagement.Events;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Category;
using InventoryManagement.UI.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Category
{
    public class CategoryController : IController<CategoryControl>
    {

        public CategoryController(CategoryControl UIControl) 
            : base(UIControl)
        {
            SetEventHandler(new EventHandler_Category(this));
        }

        public void Initialize()
        {
            InitializeTable();
        }

        private void InitializeTable()
        {
            var categoryList = DataService.GetCategoryDataController().GetAll();

            foreach (var category in categoryList)
                AddCategoryToTable(category);
        }

        public void AddCategoryToTable(CategoryGet category)
        {
            var Table = m_UIControl.categoryDataView;
            int Index = Table.Rows.Add();
            DataGridViewRow NewRow = Table.Rows[Index];
            NewRow.Cells["TableColumn_Category_ID"].Value = category.ID;
            NewRow.Cells["TableColumn_Category_Name"].Value = category.Name;
            NewRow.Cells["TableColumn_Category_Description"].Value = category.Description;
        }

        public void OpenForm_EditCategory()
        {
            Form_CategoryDetails editCategory = new Form_CategoryDetails();
            var rows = m_UIControl.categoryDataView.SelectedRows;
            if (rows.Count > 0)
            {
                int selectedRowIndex = m_UIControl.categoryDataView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = m_UIControl.categoryDataView.Rows[selectedRowIndex];
                editCategory.tb_categoryName.Text = selectedRow.Cells["TableColumn_Category_Name"].Value.ToString(); ;
                editCategory.tb_categoryDescription.Text = selectedRow.Cells["TableColumn_Category_Description"].Value.ToString();
            }
            editCategory.ShowDialog();
        }

        protected override void RegisterEvents()
        {
            RegisterEvent(EventType.NewEntryAdded);
        }

    }
}
