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
     |  |              Email: kelistudy@163.com              |  |  |     |         |      |
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

using KeLi.MsgGame.App.Components;
using KeLi.MsgGame.App.Properties;
using System.Drawing;

namespace KeLi.MsgGame.App.Forms
{
    public sealed partial class FurnishPropertyForm : ShadowForm
    {
        public FurnishPropertyForm()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Resources.Furnish);

            ftcTitle.SetFurnishName(Resources.ZhenYao_TengLongHuShou_15);
            ftcTitle.SetFurnishType(Resources.ZhuangBei_HuShou);
            ftcTitle.SetIsBinding(Resources.YiBangDing);
            ftcTitle.SetEnhance(Resources.WuXing);
            ftcTitle.SetCanDiscard(Resources.BuKe_DiuQi);
            ftcTitle.SetCanSplit(Resources.BuKe_FenJie);

            bpcProperty.SetFirstProperty(Resources.LiLiang_2550);
            bpcProperty.SetSecondProperty(Resources.MinJie_1550);
            bpcProperty.SetThirdProperty(Resources.ZhiLi_1550);
            bpcProperty.SetFourthProperty(Resources.LingLi_3950);

            fscZytz.SetSuitName(Resources.ZhenYao_TengLongTaoZhuang);
            fscZytz.SetNecklace(Resources.ZhenYao_TengLongJieZhi);
            fscZytz.SetRing(Resources.ZhenYao_TengLongXiangLian);
            fscZytz.SetCloth(Resources.ZhenYao_TengLongZhanKai);
            fscZytz.SetBelt(Resources.ZhenYao_TengLongYaoDai);
            fscZytz.SetHandguard(Resources.ZhenYao_TengLongHuShou);
            fscZytz.SetShoe(Resources.ZhenYao_TengLongZhanXue);
            fscZytz.SetMark(Resources.ZhenYao_TengLongYin);

            mcMosaic.SetMosaicName(Resources.XiangQianKa_MingCheng);
            mcMosaic.SetFirstProperty(Resources.LiLiang_1000);
            mcMosaic.SetSecondProperty(Resources.PoJia_86);

            mcWqzx.SetMagicName(Resources.JiNeng_MingCheng4);
            mcWqzx.SetMagicDetail(Resources.JiNeng_MiaoShu4);

            lblArmStory.Text = Resources.ZhuangBei_GuShi;
            lblFightPower.Text = "131000";
        }
    }
}