using System.ComponentModel;

using KeLi.GameFactory.Components;

namespace KeLi.MengSang.Parts
{
    public partial class FurnishTypeComponent : ShadowControl
    {
        public FurnishTypeComponent()
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