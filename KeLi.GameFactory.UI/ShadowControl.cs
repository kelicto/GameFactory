using System.Windows.Forms;

using KeLi.GameFactory.UI.Utils;

namespace KeLi.GameFactory.UI
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