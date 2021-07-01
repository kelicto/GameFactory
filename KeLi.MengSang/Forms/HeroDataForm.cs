using System.Drawing;

using KeLi.GameFactory.UI;
using KeLi.MengSang.Properties;

namespace KeLi.MengSang.Forms
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