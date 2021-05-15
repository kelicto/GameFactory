using System;
using System.Windows.Forms;

using KeLi.GameFactory.Components.Utils;

namespace KeLi.GameFactory.Components
{
    public partial class ShadowFrm : Form
    {
        public ShadowFrm()
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

        private void ShadowForm_Load(object sender, EventArgs e)
        {
            Location = this.GetPostitonPoint();
        }
    }
}