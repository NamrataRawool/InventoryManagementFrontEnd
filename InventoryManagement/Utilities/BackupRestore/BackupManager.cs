using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Utilities.BackupRestore
{
    public static class BackupManager
    {

        public static void BackupDatabase()
        {
            string currentDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string databasePath = currentDir + "/InventoryDb.db" ;

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            string directoryPath = dialog.SelectedPath;
            string backupFilename = "InventoryDb-" + DateTime.Today.ToLongDateString().ToString() + ".db";
            string backupFilepath = directoryPath + backupFilename;
            File.Copy(databasePath, backupFilepath, true);
        }

    }
}
