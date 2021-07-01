using System.ComponentModel;

using KeLi.GameFactory.UI;

namespace KeLi.MengSang.Parts
{
    public partial class MagicControl : ShadowControl
    {
        public MagicControl()
        {
            InitializeComponent();
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string MagicName
        {
            get => lblMagicName.Text;
            set => lblMagicName.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string MagicDetail
        {
            get => lblMagicDetail.Text;
            set => lblMagicDetail.Text = value;
        }
    }
}