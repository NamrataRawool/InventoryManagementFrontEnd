using InventoryManagement.Broadcaster;
using InventoryManagement.EventHandlers.Product;
using InventoryManagement.Events;
using InventoryManagement.Events.Product;
using InventoryManagement.UI.Product;
using InventoryManagement.UI.UserControls;

namespace InventoryManagement.Controllers
{
    public class ProductController : IController<ProductControl>
    {
        public ProductController(ProductControl UIControl)
            : base(UIControl)
        {
            SetEventHandler(new EventHandler_Product(this));
        }

        public void OnAddNewProductClicked()
        {
            var e = new Event_AddProduct();
            EventBroadcaster.Get().BroadcastEvent(e);
        }

        public void OpenAddNewProductWindow()
        {
            Form_AddProduct addProduct = new Form_AddProduct();
            addProduct.Text = "Add Product";
            addProduct.ShowDialog();
        }

        protected override void RegisterEvents()
        {
            RegisterEvent(EventType.UI_Product_AddNewProduct);
        }
    }
}
