using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToggleButtonTest.ToggleButton.Common
{
    /// <summary>
    /// 可设置圆角的矩形区域
    /// </summary>
    public class RectangleR
    {
        #region Initializes

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="rect">The roundRect.</param>
        /// <param name="cornerRadius">The corner radius.</param>
        public RectangleR(Rectangle rect, int cornerRadius)
        {
            this.Rect = rect;
            this.CornerRadius = cornerRadius;
        }

        #endregion

        #region Properties

        /// <summary>
        /// 获取或者设置矩形区域
        /// </summary>
        public Rectangle Rect { get; set; }

        /// <summary>
        /// 获取或者设置圆角值
        /// </summary>
        public int CornerRadius { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// 获取该圆角矩形的GraphicsPath对象(圆角使用Bezier曲线实现)
        /// </summary>
        public GraphicsPath ToGraphicsBezierPath()
        {
            GraphicsPath path = new GraphicsPath();
            int x = this.Rect.X;
            int y = this.Rect.Y;
            int w = this.Rect.Width;
            int h = this.Rect.Height;
            path.AddBezier(x, y + this.CornerRadius, x, y, x + this.CornerRadius, y, x + this.CornerRadius, y);
            path.AddLine(x + this.CornerRadius, y, x + w - this.CornerRadius, y);
            path.AddBezier(x + w - this.CornerRadius, y, x + w, y, x + w, y + this.CornerRadius, x + w, y + this.CornerRadius);
            path.AddLine(x + w, y + this.CornerRadius, x + w, y + h - this.CornerRadius);
            path.AddBezier(x + w, y + h - this.CornerRadius, x + w, y + h, x + w - this.CornerRadius, y + h, x + w - this.CornerRadius, y + h);
            path.AddLine(x + w - this.CornerRadius, y + h, x + this.CornerRadius, y + h);
            path.AddBezier(x + this.CornerRadius, y + h, x, y + h, x, y + h - this.CornerRadius, x, y + h - this.CornerRadius);
            path.AddLine(x, y + h - this.CornerRadius, x, y + this.CornerRadius);
            path.CloseFigure();
            return path;
        }
        #endregion
    }
}
