using System.ComponentModel;

namespace KeLi.GameFactory.Components.Parts
{
    public partial class AlchemyComponent : GameComponent
    {
        public AlchemyComponent()
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