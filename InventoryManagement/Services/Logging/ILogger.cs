using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.Logging
{
    public abstract class ILogger
    {
        public abstract void LogInfo(string message);
        public abstract void LogError(string message);
        public abstract void LogWarning(string message);
    }
}
