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