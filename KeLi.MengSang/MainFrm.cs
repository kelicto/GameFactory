using System.Drawing;
using System.Windows.Forms;

using KeLi.MengSang.Properties;

namespace KeLi.MengSang
{
    public sealed partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Resources.Back);
        }
    }
}