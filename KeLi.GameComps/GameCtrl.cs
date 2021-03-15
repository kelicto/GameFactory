using System.Windows.Forms;

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
                Handle.CanMove();
        }
    }
}