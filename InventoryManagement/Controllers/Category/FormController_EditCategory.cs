using InventoryManagement.Broadcaster;
using InventoryManagement.Events.Common;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Category
{
    public class FormController_EditCategory : IController<Form_EditCategory>
    {
        private CategoryGet m_Category;

        public FormController_EditCategory(int categoryID, Form_EditCategory UIControl)
            : base(UIControl)
        {
            Initialize(categoryID);
        }

        public void Initialize(int categoryID)
        {
            InitializeCategoryDetails(categoryID);
        }

        public void UpdateCategory()
        {
            m_UIControl.lbl_CategoryError.Text = string.Empty;
            if (!Validate())
            {
                MessageBox.Show("Name and Description cannot be empty!");
                return;
            }
            var category = DataService.GetCategoryDataController().GetByName(m_UIControl.tb_categoryName.Text);
            if (category != null)
            {
                m_UIControl.lbl_CategoryError.Text = "Category with same name already exists!";
                return;
            }
            CategoryPost categoryPost = new CategoryPost();
            categoryPost.ID = int.Parse(m_UIControl.tb_ID.Text);
            categoryPost.Name = m_UIControl.tb_categoryName.Text;
            categoryPost.Description = m_UIControl.tb_categoryDescription.Text;

            m_Category = DataService.GetCategoryDataController().Put(categoryPost);

            string message = (m_Category == null) ? "Failed to Update Product Details!" : "Product Details updated successfully!";
            MessageBox.Show(m_UIControl, message);

            // fire category update event
            Event_EntryUpdated e = new Event_EntryUpdated(DBEntityType.CATEGORY, m_Category.ID);
            EventBroadcaster.Get().BroadcastEvent(e);

            m_UIControl.Close();
        }

        private bool Validate()
        {
            if (string.IsNullOrEmpty(m_UIControl.tb_categoryName.Text.Trim()))
                return false;

            if (string.IsNullOrEmpty(m_UIControl.tb_categoryDescription.Text.Trim()))
                return false;

            return true;
        }


        private void InitializeCategoryDetails(int categoryID)
        {
            m_Category = DataService.GetCategoryDataController().Get(categoryID);

            m_UIControl.tb_ID.Text = m_Category.ID.ToString();
            m_UIControl.tb_categoryName.Text = m_Category.Name;
            m_UIControl.tb_categoryDescription.Text = m_Category.Description;
        }

        protected override void RegisterEvents()
        {
        }
    }
}
