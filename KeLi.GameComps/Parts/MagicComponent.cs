using System.ComponentModel;

namespace KeLi.GameFactory.Components.Parts
{
    public partial class MagicComponent : GameComponent
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