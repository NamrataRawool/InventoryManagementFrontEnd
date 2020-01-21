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
        public Form_AddCategory()
        {
            InitializeComponent();
        }

        private void btn_ResetCategory_Click(object sender, EventArgs e)
        {
            tb_categoryName.Text = string.Empty;
            tb_categoryDescription.Text = string.Empty;
        }

        private void btn_cancelCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_saveCategory_Click(object sender, EventArgs eventArgs)
        {
            string name = tb_categoryName.Text;
            string desc = tb_categoryDescription.Text;

            CategoryPost categoryPost = new CategoryPost();
            categoryPost.Name = name;
            categoryPost.Description = desc;

            var newCategory = DataService.GetCategoryDataController().Post(categoryPost);
            if (newCategory == null)
            {
                Assert.Do("Failed to add category!");
                return;
            }

            // broadcast new entry added event
            Event_NewEntryAdded e = new Event_NewEntryAdded(DBEntityType.CATEGORY, newCategory.ID);
            EventBroadcaster.Get().BroadcastEvent(e);

            MessageBox.Show("Category Added successfully!");
        }
    }
}
