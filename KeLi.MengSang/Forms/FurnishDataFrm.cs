using System.Drawing;

using KeLi.GameFactory.Components;
using KeLi.MengSang.Properties;

namespace KeLi.MengSang.Forms
{
    public sealed partial class FurnishDataFrm : ShadowForm
    {
        public FurnishDataFrm()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Resources.Furnish);

            ftcTitle.FurnishName = Resources.CL_DL_HuShou_15;
            ftcTitle.FurnishType = Resources.ZhuangBei_HuShou;
            ftcTitle.IsBinding = Resources.YiBangDing;
            ftcTitle.Enhance = Resources.WuXing;
            ftcTitle.CanDiscard = Resources.BuKe_DiuQi;
            ftcTitle.CanSplit = Resources.BuKe_FenJie;

            bpcProperty.FirstProperty = Resources.LiLiang_2550;
            bpcProperty.SecondProperty = Resources.MinJie_1550;
            bpcProperty.ThirdProperty = Resources.ZhiLi_1550;
            bpcProperty.FourthProperty = Resources.LingLi_3950;

            fscZytz.SuitName = Resources.CL_DL_TaoZhuang;
            fscZytz.Necklace = Resources.CL_DL_JieZhi;
            fscZytz.Ring = Resources.CL_DL_XiangLian;
            fscZytz.Cloth = Resources.CL_DL_ZhanKai;
            fscZytz.Belt = Resources.CL_DL_YaoDai;
            fscZytz.Handguard = Resources.CL_DL_HuShou;
            fscZytz.Shoe = Resources.CL_DL_ZhanXue;
            fscZytz.Mark = Resources.CL_DL_Yin;

            mcMosaic.MosaicName = Resources.XiangQianKa_MingCheng;
            mcMosaic.FirstProperty = Resources.LiLiang_1000;
            mcMosaic.SecondProperty = Resources.PoJia_86;

            acAlchemy.MagicName = Resources.JiNeng_MingCheng4;
            acAlchemy.MagicDetail = Resources.JiNeng_MiaoShu4;

            lblArmStory.Text = Resources.ZhuangBei_GuShi;
            lblFightPower.Text = "131000.0";
        }
    }
}