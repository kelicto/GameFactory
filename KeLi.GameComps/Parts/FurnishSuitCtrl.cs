using System.ComponentModel;

namespace KeLi.GameComps.Parts
{
    public partial class FurnishSuitCtrl : GameCtrl
    {
        public FurnishSuitCtrl()
        {
            InitializeComponent();
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string SuitName
        {
            get => lblSuitName.Text;
            set => lblSuitName.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string Mark
        {
            get => lblMark.Text;
            set => lblMark.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string Shoe
        {
            get => lblShoe.Text;
            set => lblShoe.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string Handguard
        {
            get => lblHandguard.Text;
            set => lblHandguard.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string Belt
        {
            get => lblBelt.Text;
            set => lblBelt.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string Cloth
        {
            get => lblCloth.Text;
            set => lblCloth.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string Necklace
        {
            get => lblNecklace.Text;
            set => lblNecklace.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string Ring
        {
            get => lblRing.Text;
            set => lblRing.Text = value;
        }
    }
}