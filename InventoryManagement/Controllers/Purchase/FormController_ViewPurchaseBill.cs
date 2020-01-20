using InventoryManagement.UI.Purchase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers.Purchase
{
    public class FormController_ViewPurchaseBill : IController<Form_ViewPuchaseBill>
    {
        public FormController_ViewPurchaseBill(Form_ViewPuchaseBill UIControl) : base(UIControl)
        {

        }
        protected override void RegisterEvents()
        {

        }
    }
}
