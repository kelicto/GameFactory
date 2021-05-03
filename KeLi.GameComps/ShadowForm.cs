using System;
using System.Windows.Forms;

using KeLi.GameComps.Utils;

namespace KeLi.GameComps
{
    public partial class ShadowForm : Form
    {
        public ShadowForm()
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