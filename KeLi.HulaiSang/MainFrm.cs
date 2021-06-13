using System.Drawing;

using KeLi.GameFactory.Components;
using KeLi.HulaiSang.Properties;

namespace KeLi.HulaiSang
{
    public sealed partial class MainFrm : ShadowForm
    {
        public MainFrm()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Resources.Back);
        }
    }
}
