using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.Logging
{
    public static class Logger
    {
        static ILogger m_logger;

        public static void Initialize(LoggerType type)
        {
            switch (type)
            {
                case LoggerType.TextFile:
                    m_logger = new TextFileLogger();
                    break;
            }
        }
        public static void LogInfo(string message)
        {
            m_logger.LogInfo(message);
        }

        public static void LogError(string message)
        {
            m_logger.LogError(message);
        }

        public static void LogWarning(string message)
        {
            m_logger.LogWarning(message);
        }
    }

    public enum LoggerType
    {
        TextFile
    }
}
