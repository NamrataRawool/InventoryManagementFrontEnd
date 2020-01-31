using InventoryManagement.Controllers.Product;
using InventoryManagement.Events;
using InventoryManagement.Events.Common;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;

namespace InventoryManagement.EventHandlers.Product
{
    public class EventHandler_AddProduct : IEventHandler<FormController_AddProduct>
    {
        public EventHandler_AddProduct(FormController_AddProduct Controller) 
            : base(Controller)
        {
        }

        public override void OnEvent(IEvent e)
        {
            EventType type = e.Type();
            switch (type)
            {
                case EventType.NewEntryAdded:
                    HandleEvent_NewEntryAdded(e.Cast<Event_NewEntryAdded>());
                    break;
            }
        }

        private void HandleEvent_NewEntryAdded(Event_NewEntryAdded e)
        {
            DBEntityType entityType = e.GetEntityType();
            int id = e.GetID();

            if (entityType == DBEntityType.CATEGORY)
            {
                CategoryGet category = DataService.GetCategoryDataController().Get(id);
                m_Controller.AddCategoryToComboBox(category);
            }
        }

    }
}
