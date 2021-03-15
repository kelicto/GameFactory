using System.ComponentModel;

namespace KeLi.GameComps.Parts
{
    public partial class AlchemyCtrl : GameCtrl
    {
        public AlchemyCtrl()
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