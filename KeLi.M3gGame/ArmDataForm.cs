using System.Drawing;

using KeLi.GameComps;
using KeLi.M3Game.Properties;

namespace KeLi.M3Game
{
    public sealed partial class ArmDataForm : ShadowForm
    {
        public ArmDataForm()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Resources.Arm);

            ftcTitle.FurnishName = Resources.YanMie_XingYunDao_15;
            ftcTitle.FurnishType = Resources.WuQi_DanShou;
            ftcTitle.IsBinding = Resources.YiBangDing;
            ftcTitle.Enhance = Resources.WuXing;
            ftcTitle.CanDiscard = Resources.BuKe_DiuQi;
            ftcTitle.CanSplit = Resources.BuKe_FenJie;

            bpcProperty.FirstProperty = Resources.LiLiang_2550;
            bpcProperty.SecondProperty = Resources.MinJie_1550;
            bpcProperty.ThirdProperty = Resources.ZhiLi_1550;
            bpcProperty.FourthProperty = Resources.LingLi_3950;

            ascXytz.SuitName = Resources.YanMie_XingYunTaoZhuang;
            ascXytz.SingleArm = Resources.YanMie_XingYunDao;
            ascXytz.DoubleArm = Resources.YanMie_XingYunDuiJi;
            ascXytz.SpearArm = Resources.YanMie_XingYunQiang;
            ascXytz.BowArm = Resources.YanMie_XingYunGong;
            ascXytz.ClawArm = Resources.YanMie_XingYunZhua;

            mcBfwl.MagicName = Resources.JiNeng_MingCheng1;
            mcBfwl.MagicDetail = Resources.JiNeng_MiaoShu1;

            mcGyhd.MagicName = Resources.JiNeng_MingCheng2;
            mcGyhd.MagicDetail = Resources.JiNeng_MiaoShu2;

            mcFjzz.MagicName = Resources.JiNeng_MingCheng3;
            mcFjzz.MagicDetail = Resources.JiNeng_MiaoShu3;

            mcMosaic.MosaicName = Resources.XiangQianKa_MingCheng;
            mcMosaic.FirstProperty = Resources.LiLiang_1000;
            mcMosaic.SecondProperty = Resources.PoJia_86;

            acAlchemy.MagicName = Resources.JiNeng_MingCheng4;
            acAlchemy.MagicDetail = Resources.JiNeng_MiaoShu4;

            lblArmStory.Text = Resources.ZhuangBei_GuShi;
            lblFightPower.Text = "221300.0";
        }
    }
}