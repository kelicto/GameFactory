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

using System;
using System.Drawing;
using System.Windows.Forms;

namespace KeLi.MsgGame.App.Utils
{
    public static class LocationUtil
    {
        private static readonly int _screenWidth = SystemInformation.PrimaryMonitorSize.Width;

        private static readonly int _screenHeight = SystemInformation.PrimaryMonitorSize.Height;

        public static Point GetPostitonPt(this Form form)
        {
            switch (form.StartPosition)
            {
                case FormStartPosition.CenterScreen:
                    return form.GetCenterScreenPt();

                case FormStartPosition.CenterParent:
                    return form.GetCenterParentPt();

                default:
                    return form.Location;
            }
        }

        public static Point GetCenterParentPt(this Form form)
        {
            if (form.StartPosition != FormStartPosition.CenterParent)
                throw new InvalidOperationException();

            if (form.Parent == null)
                throw new InvalidOperationException();

            var px = form.Parent.Width - form.Width < 0 ? 0 : (form.Parent.Width - form.Width) / 2;
            var py = form.Parent.Height - form.Height < 0 ? 0 : (form.Parent.Height - form.Height) / 2;

            return new Point(px, py);
        }

        public static Point GetCenterScreenPt(this Form form)
        {
            if (form.StartPosition != FormStartPosition.CenterScreen)
                throw new InvalidOperationException();

            var px = (_screenWidth - form.Width) / 2;
            var py = (_screenHeight - form.Height) / 2;

            return new Point(px, py);
        }
    }
}