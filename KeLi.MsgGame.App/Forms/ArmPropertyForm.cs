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