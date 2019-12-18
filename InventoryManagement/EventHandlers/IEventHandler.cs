using InventoryManagement.Events;

namespace InventoryManagement.EventHandlers
{

    public abstract class IEventHandler
    {
        public abstract void OnEvent(IEvent e);
    }

    public abstract class IEventHandler<CONTROLLER> : IEventHandler
    {
        protected IEventHandler(CONTROLLER Controller)
        {
            m_Controller = Controller;
        }

        protected CONTROLLER m_Controller;
    }
}
