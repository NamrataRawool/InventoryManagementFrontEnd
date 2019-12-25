using System.Diagnostics;

namespace InventoryManagement.Services.Misc.Assert
{
    public static class Assert
    {

        public static void Do(string message)
        {
            if (!IsEnabled())
                return;

            Debug.Assert(false, message);
        }

        public static void Enable() { m_Enabled = true; }
        public static void Disable() { m_Enabled = false; }

        public static bool IsEnabled() { return m_Enabled; }

        private static bool m_Enabled;

    }
}
