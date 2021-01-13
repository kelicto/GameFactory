/*
 * MIT License
 *
 * Copyright(c) 2019 KeLi
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

/*
             ,---------------------------------------------------,              ,---------,
        ,----------------------------------------------------------,          ,"        ,"|
      ,"                                                         ,"|        ,"        ,"  |
     +----------------------------------------------------------+  |      ,"        ,"    |
     |  .----------------------------------------------------.  |  |     +---------+      |
     |  | C:\>FILE -INFO                                     |  |  |     | -==----'|      |
     |  |                                                    |  |  |     |         |      |
     |  |                                                    |  |  |/----|`---=    |      |
     |  |              Author: KeLi                          |  |  |     |         |      |
     |  |              Email: kelicto@protonmail.com         |  |  |     |         |      |
     |  |              Creation Time: 11/23/2019 03:28:10 PM |  |  |     |         |      |
     |  | C:\>_                                              |  |  |     | -==----'|      |
     |  |                                                    |  |  |   ,/|==== ooo |      ;
     |  |                                                    |  |  |  // |(((( [66]|    ,"
     |  `----------------------------------------------------'  |," .;'| |((((     |  ,"
     +----------------------------------------------------------+  ;;  | |         |,"
        /_)_________________________________________________(_/  //'   | +---------+
           ___________________________/___  `,
          /  oooooooooooooooo  .o.  oooo /,   \,"-----------
         / ==ooooooooooooooo==.o.  ooo= //   ,`\--{)B     ,"
        /_==__==========__==_ooo__ooo=_/'   /___________,"
*/

using System.Drawing;

using KeLi.GameComps;
using KeLi.M3Game.Properties;

namespace KeLi.M3Game
{
    public sealed partial class FurnishDataForm : ShadowForm
    {
        public FurnishDataForm()
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