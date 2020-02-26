using InventoryManagement.UI.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
    public class DashboardController : IController<DashboardControl>
    {
        public DashboardController(DashboardControl UIControl) : base(UIControl)
        {
            Initialize();
        }
        private void Initialize()
        {
            InitilizeComboBox();
        }

        private void InitilizeComboBox()
        {
            List<string> periods = new List<string>()
            {
                "Today",
                "Weekly",
                "Monthly"
            };
            m_UIControl.cb_period.DataSource = periods;
        }

        protected override void RegisterEvents()
        {

        }
    }
}
