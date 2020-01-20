using InventoryManagement.Controllers.Category;
using InventoryManagement.Events;
using InventoryManagement.Events.Common;
using InventoryManagement.Services.Data;

namespace InventoryManagement.EventHandlers.Category
{
    public class EventHandler_Category : IEventHandler<CategoryController>
    {
        public EventHandler_Category(CategoryController Controller) 
            : base(Controller)
        {
        }

        public override void OnEvent(IEvent e)
        {
            EventType type = e.Type();
            switch(type)
            {
                case EventType.NewEntryAdded:
                    HandleEvent_NewEntryAdded(e.Cast<Event_NewEntryAdded>());
                    break;
            }
        }

        private void HandleEvent_NewEntryAdded(Event_NewEntryAdded e)
        {
            DBEntityType entityType = e.GetEntityType();

            if (entityType == DBEntityType.CATEGORY)
            {
                var category = DataService.GetCategoryDataController().Get(e.GetID());
                m_Controller.AddCategoryToTable(category);
            }
        }

    }
}
