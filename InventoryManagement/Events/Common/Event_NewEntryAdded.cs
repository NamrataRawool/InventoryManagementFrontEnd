using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Events.Common
{
    class Event_NewEntryAdded : IEvent
    {

        public Event_NewEntryAdded(DBEntityType entityType, int ID)
        {
            m_EntityType = entityType;
            m_ID = ID;
        }

        public DBEntityType GetEntityType() { return m_EntityType; }

        public int GetID() { return m_ID; }

        public override EventType Type() { return EventType.NewEntryAdded; }

        DBEntityType m_EntityType;
        int m_ID;

    }
}
