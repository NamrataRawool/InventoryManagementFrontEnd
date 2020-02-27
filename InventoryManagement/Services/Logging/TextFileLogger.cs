using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.Logging
{
    public class TextFileLogger : ILogger
    {
        string logFilePath = string.Empty;
        public TextFileLogger()
        {
            string logFileName = "Log.txt";
            string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            logFilePath = Path.Combine(directory, logFileName);
        }
        public override void LogError(string message)
        {
            var msg = "[" + DateTime.Now + "][ERR] ::[" + message + "]";
            WriteToFile(msg);
        }

        public override void LogInfo(string message)
        {
            var msg = "[" + DateTime.Now + "][INFO]::[" + message + "]";
            WriteToFile(msg);
        }

        public override void LogWarning(string message)
        {
            var msg = "[" + DateTime.Now + "][WARN]::[" + message + "]";
            WriteToFile(msg);
        }

        private void WriteToFile(string message)
        {
            using (StreamWriter writer = File.AppendText(logFilePath))
            {
                writer.WriteLine(message);
            }
        }
    }
}
