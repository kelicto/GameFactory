using System;
using System.Windows.Forms;

using KeLi.HulaiSang.Forms;

namespace KeLi.HulaiSang
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HeroListFrm());
        }
    }
}
