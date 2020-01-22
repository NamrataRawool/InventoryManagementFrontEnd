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

        private void btn_cancelCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_UpdateCategory_Click(object sender, EventArgs e)
        {
            m_Controller.UpdateCategory();
        }

    }
}
