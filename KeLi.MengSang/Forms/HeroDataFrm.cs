using System.Drawing;

using KeLi.GameFactory.Components;
using KeLi.MengSang.Properties;

namespace KeLi.MengSang.Forms
{
    public sealed partial class HeroDataFrm : ShadowForm
    {
        public HeroDataFrm()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Resources.Hero);
        }
    }
}