using KeLi.MsgGame.App.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace KeLi.MsgGame.App.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Resources.Back);
        }
    }
}