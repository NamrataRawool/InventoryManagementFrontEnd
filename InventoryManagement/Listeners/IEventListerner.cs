using InventoryManagement.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Listeners
{
    public class IEventListener
    {
        public virtual void OnEvent(IEvent e)
        {
        }
    }
}
