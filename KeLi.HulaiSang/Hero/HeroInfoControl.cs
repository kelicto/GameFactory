using KeLi.GameFactory.UI;
using KeLi.HulaiSang.Properties;

namespace KeLi.HulaiSang.Hero
{
    public partial class HeroInfoControl : ShadowControl
    {
        public HeroInfoControl()
        {
            InitializeComponent();

            pbHeader.Image = Resources.LvBu;
            pbJN1.Image = Resources.ZhanShenZhiNu;
            pbJN2.Image = Resources.XueZhaiXueChang;
            pbJN3.Image = Resources.QiGuanChangHong;
            pbJN4.Image = Resources.DouZhuanXingYi;
            pbJN5.Image = Resources.FanKeWeiZhu;
            pbJN6.Image = Resources.YiYiDaiLao;

            pbZB1.Image = Resources.YuLei;
            pbZB2.Image = Resources.BaWang;
            pbZB3.Image = Resources.ZhuiFeng;
            pbZB4.Image = Resources.LongYa;
        }
    }
}
