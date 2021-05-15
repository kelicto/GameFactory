using System;
using System.Windows.Forms;

using KeLi.M3Game.Forms;

namespace KeLi.M3Game
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