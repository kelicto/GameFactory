using System.Windows.Forms;

using KeLi.GameFactory.Components.Utils;

namespace KeLi.GameFactory.Components
{
    public partial class ShadowControl : UserControl
    {
        protected ShadowControl()
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