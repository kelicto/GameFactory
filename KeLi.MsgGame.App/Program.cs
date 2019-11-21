using KeLi.MsgGame.App.Forms;
using System;
using System.Windows.Forms;

namespace KeLi.MsgGame.App
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}