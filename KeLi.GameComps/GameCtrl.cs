using System.Windows.Forms;

using KeLi.GameComps.Utils;

namespace KeLi.GameComps
{
    public partial class GameCtrl : UserControl
    {
        protected GameCtrl()
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