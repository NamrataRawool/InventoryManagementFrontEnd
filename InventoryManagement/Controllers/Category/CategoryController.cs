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

        public void UpdateCategoryInTable(CategoryGet category)
        {
            var table = m_UIControl.categoryDataView;

            for (int i = 0; i < table.Rows.Count; ++i)
            {
                DataGridViewRow row = table.Rows[i];
                int id = int.Parse(row.Cells["TableColumn_Category_ID"].Value.ToString());

                if (category.ID == id)
                {
                    row.Cells["TableColumn_Category_ID"].Value = category.ID;
                    row.Cells["TableColumn_Category_Name"].Value = category.Name;
                    row.Cells["TableColumn_Category_Description"].Value = category.Description;
                    return;
                }
            }
        }

        public void UpdateTableByCategoryName(string name)
        {
            var Table = m_UIControl.categoryDataView;

            foreach (DataGridViewRow row in Table.Rows)
            {
                bool visible = false;
                var categoryName = row.Cells["TableColumn_Category_Name"].Value.ToString().ToLower();
                if (categoryName.StartsWith(name.ToLower()))
                    visible = true;

                row.Visible = visible;
            }
            return;
        }


        public void OpenForm_EditCategory()
        {
            var table = m_UIControl.categoryDataView;

            if (table.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select an item to update!");
                return;
            }

            int selectedRowIndex = table.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = table.Rows[selectedRowIndex];
            int categoryID = int.Parse(selectedRow.Cells["TableColumn_Category_ID"].Value.ToString());

            Form_EditCategory form = new Form_EditCategory(categoryID);
            form.ShowDialog();
        }

        public void OpenForm_AddCategory()
        {
            Form_AddCategory addCategory = new Form_AddCategory();
            addCategory.ShowDialog();
        }

        protected override void RegisterEvents()
        {
            RegisterEvent(EventType.NewEntryAdded);
            RegisterEvent(EventType.EntryUpdated);
        }

    }
}
