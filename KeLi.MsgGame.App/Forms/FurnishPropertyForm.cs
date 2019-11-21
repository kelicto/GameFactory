using KeLi.MsgGame.App.Components;
using KeLi.MsgGame.App.Properties;
using System.Drawing;

namespace KeLi.MsgGame.App.Forms
{
    public partial class FurnishPropertyForm : ShadowForm
    {
        public FurnishPropertyForm()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Resources.Furnish);

            FtcTitle.LblFurnishName.Text = Resources.ZhenYao_TengLongHuShou_15;
            FtcTitle.LblFurnishType.Text = Resources.ZhuangBei_HuShou;
            FtcTitle.LblIsBinding.Text = Resources.YiBangDing;
            FtcTitle.LblEnhance.Text = Resources.WuXing;
            FtcTitle.LblCanDiscard.Text = Resources.BuKe_DiuQi;
            FtcTitle.LblCanSplit.Text = Resources.BuKe_FenJie;

            BpcProperty.LblFirstProperty.Text = Resources.LiLiang_2550;
            BpcProperty.LblSecondProperty.Text = Resources.MinJie_1550;
            BpcProperty.LblThirdProperty.Text = Resources.ZhiLi_1550;
            BpcProperty.LblFourthProperty.Text = Resources.LingLi_3950;

            FscZytz.LblSuitName.Text = Resources.ZhenYao_TengLongTaoZhuang;
            FscZytz.LblRing.Text = Resources.ZhenYao_TengLongJieZhi;
            FscZytz.LblNecklace.Text = Resources.ZhenYao_TengLongXiangLian;
            FscZytz.LblCloth.Text = Resources.ZhenYao_TengLongZhanKai;
            FscZytz.LblBelt.Text = Resources.ZhenYao_TengLongYaoDai;
            FscZytz.LblHandguard.Text = Resources.ZhenYao_TengLongHuShou;
            FscZytz.LblShoe.Text = Resources.ZhenYao_TengLongZhanXue;
            FscZytz.LblMark.Text = Resources.ZhenYao_TengLongYin;

            McMosaic.LblMosaicName.Text = Resources.XiangQianKa_MingCheng;
            McMosaic.LblFirstProperty.Text = Resources.LiLiang_1000;
            McMosaic.LblSecondProperty.Text = Resources.PoJia_86;

            McWqzx.LblMagicName.Text = Resources.JiNeng_MingCheng4;
            McWqzx.LblMagicDetail.Text = Resources.JiNeng_MiaoShu4;

            LblArmStory.Text = Resources.ZhuangBei_GuShi;
            LblFightPower.Text = "231000";
        }
    }
}