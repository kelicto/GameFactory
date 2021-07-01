using System.Drawing;

using KeLi.GameFactory.UI;
using KeLi.HulaiSang.Properties;

namespace KeLi.HulaiSang
{
    public sealed partial class MainForm : ShadowForm
    {
        public MainForm()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Resources.Back);
        }
    }
}
