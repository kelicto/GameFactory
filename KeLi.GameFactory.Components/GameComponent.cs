using System.Windows.Forms;

using KeLi.GameFactory.Components.Utils;

namespace KeLi.GameFactory.Components
{
    public partial class GameComponent : UserControl
    {
        protected GameComponent()
        {
            InitializeComponent();
            Handle.SetShadowStyle();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
                Handle.MoveWindow();
        }
    }
}