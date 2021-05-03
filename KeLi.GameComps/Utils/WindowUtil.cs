using System;
using System.Windows.Forms;

namespace KeLi.GameComps.Utils
{
    public static class WindowUtil
    {
        private const int CS_DROP_SHADOW = 0x20000;

        private const int GCL_STYLE = -26;

        private const int HTCAPTION = 2;

        private const int WM_NCLBUTTONDOWN = 0x00A1;

        public static void SetShadowStyle(this IntPtr handle)
        {
            handle.SetClassLong(GCL_STYLE, handle.GetClassLong(GCL_STYLE) | CS_DROP_SHADOW);
        }

        public static void MoveWindow(this IntPtr handle)
        {
            User32Importer.ReleaseCapture();

            var control = Control.FromHandle(handle);

            if (control is Form)
                control.Handle.SendMessage(WM_NCLBUTTONDOWN, HTCAPTION, 0);

            else
                control.FindForm()?.Handle.SendMessage(WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}