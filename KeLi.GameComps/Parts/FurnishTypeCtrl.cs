using System.ComponentModel;

namespace KeLi.GameComps.Parts
{
    public partial class FurnishTypeCtrl : GameCtrl
    {
        public FurnishTypeCtrl()
        {
            InitializeComponent();
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string FurnishName
        {
            get => lblFurnishName.Text;
            set => lblFurnishName.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string FurnishType
        {
            get => lblFurnishType.Text;
            set => lblFurnishType.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string IsBinding
        {
            get => lblIsBinding.Text;
            set => lblIsBinding.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string Enhance
        {
            get => lblEnhance.Text;
            set => lblEnhance.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string CanDiscard
        {
            get => lblCanDiscard.Text;
            set => lblCanDiscard.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string CanSplit
        {
            get => lblCanSplit.Text;
            set => lblCanSplit.Text = value;
        }
    }
}