using System.Drawing;
using System.Windows.Forms;

using KeLi.MengSang.Properties;

namespace KeLi.MengSang
{
    public sealed partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Resources.Back);
        }
    }
}