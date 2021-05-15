using System.Drawing;

using KeLi.GameFactory.Components;
using KeLi.M3Game.Properties;

namespace KeLi.M3Game.Forms
{
    public sealed partial class HeroDataFrm : ShadowFrm
    {
        public HeroDataFrm()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Resources.Hero);
        }
    }
}