using System;
using System.Runtime.InteropServices;

namespace KeLi.GameComps
{
    public static class ShadowUtil
    {
        private const int CS_DROP_SHADOW = 0x20000;

        private const int GCL_STYLE = -26;

        private const int HTCAPTION = 2;

        private const int WM_NCLBUTTONDOWN = 0x00A1;

        public static void SetShadowStyle(this IntPtr handle)
        {
            handle.SetClassLong(GCL_STYLE, handle.GetClassLong(GCL_STYLE) | CS_DROP_SHADOW);
        }

        public static void CanMove(this IntPtr handle)
        {
            ReleaseCapture();
            handle.SendMessage(WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SetClassLong(this IntPtr hwnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetClassLong(this IntPtr hwnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(this IntPtr hWnd, int msg, int wParam, int lParam);
    }
}