using InventoryManagement.Broadcaster;
using InventoryManagement.Events.Common;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.Services.Misc.Assert;
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
    public partial class Form_AddCategory : Form
    {
        private CategoryGet m_Category;

        public Form_AddCategory()
        {
            InitializeComponent();
        }

        private void btn_ResetCategory_Click(object sender, EventArgs e)
        {
            tb_categoryName.Text = string.Empty;
            tb_categoryDescription.Text = string.Empty;
            lbl_CategoryError.Text = string.Empty;
        }

        private void btn_saveCategory_Click(object sender, EventArgs eventArgs)
        {
            if (!Validate())
                return;

            lbl_CategoryError.Text = string.Empty;
            string name = tb_categoryName.Text.Trim();
            string desc = tb_categoryDescription.Text.Trim();

            var category = DataService.GetCategoryDataController().GetByName(name);
            if (category != null)
            {
                lbl_CategoryError.Text = "Category with same name already exists!";
                return;
            }
            CategoryPost categoryPost = new CategoryPost();
            categoryPost.Name = name;
            categoryPost.Description = desc;

            m_Category = DataService.GetCategoryDataController().Post(categoryPost);
            if (m_Category == null)
            {
                Assert.Do("Failed to add category!");
                DialogResult = DialogResult.Cancel;
                return;
            }

            DialogResult = DialogResult.OK;

            // broadcast new entry added event
            Event_NewEntryAdded e = new Event_NewEntryAdded(DBEntityType.CATEGORY, m_Category.ID);
            EventBroadcaster.Get().BroadcastEvent(e);
            this.Close();
            MessageBox.Show("Category Added successfully!");
        }

        private bool Validate()
        {
            if (string.IsNullOrEmpty(tb_categoryName.Text.Trim()))
            {
                lbl_CategoryError.Text = "Category Name cannot be empty!";
                return false;
            }

            return true;
        }

        public CategoryGet GetAddedCategory() { return m_Category; }

    }
}
