using System.ComponentModel;

using KeLi.GameFactory.Components;

namespace KeLi.MengSang.Parts
{
    public partial class MagicComponent : ShadowControl
    {
        public MagicComponent()
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