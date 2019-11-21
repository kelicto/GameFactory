using System.Drawing;
using KeLi.MsgGame.App.Components;
using KeLi.MsgGame.App.Properties;

namespace KeLi.MsgGame.App.Forms
{
    partial class ArmPropertyForm : ShadowForm
    {
        public ArmPropertyForm()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Resources.Arm);

            FtcTitle.LblFurnishName.Text = Resources.YanMie_XingYunDao_15;
            FtcTitle.LblFurnishType.Text = Resources.WuQi_DanShou;
            FtcTitle.LblIsBinding.Text = Resources.YiBangDing;
            FtcTitle.LblEnhance.Text = Resources.WuXing;
            FtcTitle.LblCanDiscard.Text = Resources.BuKe_DiuQi;
            FtcTitle.LblCanSplit.Text = Resources.BuKe_FenJie;

            BpcProperty.LblFirstProperty.Text = Resources.LiLiang_2550;
            BpcProperty.LblSecondProperty.Text = Resources.MinJie_1550;
            BpcProperty.LblThirdProperty.Text = Resources.ZhiLi_1550;
            BpcProperty.LblFourthProperty.Text = Resources.LingLi_3950;

            AscXytz.LblSuitName.Text = Resources.YanMie_XingYunTaoZhuang;
            AscXytz.LblSingleArm.Text = Resources.YanMie_XingYunDao;
            AscXytz.LblDoubleArm.Text = Resources.YanMie_XingYunDuiJi;
            AscXytz.LblSpear.Text = Resources.YanMie_XingYunQiang;
            AscXytz.LblBow.Text = Resources.YanMie_XingYunGong;
            AscXytz.LblClaw.Text = Resources.YanMie_XingYunZhua;

            McBfwl.LblMagicName.Text = Resources.JiNeng_MingCheng1;
            McBfwl.LblMagicDetail.Text = Resources.JiNeng_MiaoShu1;
            McGyhd.LblMagicName.Text = Resources.JiNeng_MingCheng2;
            McGyhd.LblMagicDetail.Text = Resources.JiNeng_MiaoShu2;
            McFjzz.LblMagicName.Text = Resources.JiNeng_MingCheng3;
            McFjzz.LblMagicDetail.Text = Resources.JiNeng_MiaoShu3;

            McMosaic.LblMosaicName.Text = Resources.XiangQianKa_MingCheng;
            McMosaic.LblFirstProperty.Text = Resources.LiLiang_1000;
            McMosaic.LblSecondProperty.Text = Resources.PoJia_86;

            McWqzx.LblMagicName.Text = Resources.JiNeng_MingCheng4;
            McWqzx.LblMagicDetail.Text = Resources.JiNeng_MiaoShu4;

            LblArmStory.Text = Resources.ZhuangBei_GuShi;
            LblFightPower.Text = "351300";
        }
    }
}