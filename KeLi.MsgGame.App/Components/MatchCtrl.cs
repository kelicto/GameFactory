using KeLi.MsgGame.App.Forms;

namespace KeLi.MsgGame.App.Components
{
    public partial class MatchCtrl : GameCtrl
    {
        public MatchCtrl()
        {
            InitializeComponent();
        }

        private void LblMatch_Click(object sender, System.EventArgs e)
        {
            new ArmPropertyForm().Show();
            new FurnishPropertyForm().Show();
            new HeroPropertyForm().Show();
        }

        private void LblLeft_Click(object sender, System.EventArgs e)
        {
        }

        private void LblRight_Click(object sender, System.EventArgs e)
        {
        }
    }
}