using KeLi.MsgGame.App.Components;
using KeLi.MsgGame.App.Properties;
using System.Drawing;

namespace KeLi.MsgGame.App.Forms
{
    public partial class HeroPropertyForm : ShadowForm
    {
        public HeroPropertyForm()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Resources.Hero);
        }
    }
}