using InventoryManagement.Controllers;
using InventoryManagement.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.EventHandlers
{

    public class IEventHandler
    {
        public virtual void OnEvent(IEvent e) { }
    }

    public abstract class IEventHandler<Controller> : IEventHandler
    {
        public IEventHandler(Controller Controller)
        {
            m_Controller = Controller;
        }

        protected Controller m_Controller;
    }
}
