using System;
using System.Windows.Forms;

using KeLi.MengSang.Forms;

namespace KeLi.MengSang
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HeroDataFrm());
        }
    }
}