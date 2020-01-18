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
            if (type == EventType.NewEntryAdded)
            {
                var evnt = e.Cast<Event_NewEntryAdded>();
                if (evnt.GetEntityType() == DBEntityType.CATEGORY)
                {
                    var category = DataService.GetCategoryDataController().Get(evnt.GetID());
                    m_Controller.AddCategoryToTable(category);
                }
            }
        }
    }
}
