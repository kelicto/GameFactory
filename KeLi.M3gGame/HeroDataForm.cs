using System.Drawing;

using KeLi.GameComps;
using KeLi.M3Game.Properties;

namespace KeLi.M3Game
{
    public sealed partial class HeroDataForm : ShadowForm
    {
        public HeroDataForm()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Resources.Hero);
        }
    }
}