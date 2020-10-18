using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToggleButtonTest.ToggleButton.TypeConverters;
using System.Drawing.Drawing2D;
using ToggleButtonTest.ToggleButton.Common;

namespace ToggleButtonTest.ToggleButton
{
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(CheckBox))]
    public partial class ToggleButton : Control
    {
        private ToggleButtonStyle _ToggleButtonStyle;
        private Rectangle _MouseRect;
        private bool _Checked;
        private Color _StateColor;
        private bool _DotFocus;
        private bool _DotClick;
        private bool _EnabledToggle = true;

        /// <summary>
        /// ToggleButton状态改变
        /// 返回true，ToggleButton状态改变，否则状态回滚
        /// </summary>
        /// <returns></returns>
        public delegate bool DelToggleStateChanged(bool isChecked);
        [Browsable(true), Description("ToggleButton状态改变")]
        public event DelToggleStateChanged OnToggleStateChanged;

        public ToggleButton()
        {
            InitializeComponent();
            this.Size = new Size(70, 35);
            _ToggleButtonStyle = new ToggleButtonStyle(this);
            //SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.UserMouse |
                ControlStyles.Selectable |
                ControlStyles.StandardClick, true);
        }

        [Browsable(true), Description("ToggleButton样式设置"), Category("ToggleButton")]
        [Localizable(true)]
        [MergableProperty(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ToggleButtonStyle ButtonStyle
        {
            get
            {
                return _ToggleButtonStyle;
            }
            set
            {
                _ToggleButtonStyle = value;
            }
        }

        /// <summary>
        /// 设置ToggleButton可操作性，相当于Enabled
        /// </summary>
        [Browsable(true), Description("设置ToggleButton可操作性")]
        public bool EnabledToggle
        {
            get
            {
                return _EnabledToggle;
            }
            set
            {
                if (_EnabledToggle != value)
                {
                    _EnabledToggle = value;
                    _DotClick = false;
                    _DotFocus = false;
                    this.Invalidate();
                }
            }
        }

        /// <summary>
        /// 请使用EnableToogle
        /// </summary>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new  bool Enabled { get { return false; } set{  } }



        /// <summary>
        /// ToggleButton是否选中
        /// </summary>
        [Browsable(true), Description("ToggleButton是否选中")]
        public bool Checked
        {
            get
            {
                return _Checked;
            }
            set
            {
                //如果value值未改变，则放弃执行，减少UI渲染，避免不必要的刷新Invalidate()
                if (_Checked == value)
                {
                    return;
                }
                _DotClick = false;
                _DotFocus = false;
                _Checked = value;
                this.Invalidate();
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_MouseRect != null && _MouseRect.Contains(new Point(e.X, e.Y)) && this.EnabledToggle)
                {
                    Checked = !Checked;
                    if (OnToggleStateChanged != null)
                    {
                        var suc = OnToggleStateChanged(Checked);
                        if (!suc)
                        {
                            Checked = !Checked;
                        }
                    }
                }
            }
            base.OnMouseClick(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            var dotFocus = EnabledToggle && _MouseRect != null && _MouseRect.Contains(new Point(e.X, e.Y));
            if (_DotFocus != dotFocus)
            {
                _DotFocus = dotFocus;
                this.Invalidate();
            }
            base.OnMouseMove(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _DotClick = EnabledToggle && _MouseRect != null && _MouseRect.Contains(new Point(e.X, e.Y));
                if (_DotClick)
                {
                    this.Invalidate();
                }
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (_DotClick)
            {
                _DotClick = false;
                this.Invalidate();
            }
            base.OnMouseDown(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;  //使绘图质量最高，即消除锯齿
            var dotDis = this.ClientRectangle.Width > this.ClientRectangle.Height ? this.Height : this.Width;
            var rect = new Rectangle(0, 0, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1);
            var bRect = new Rectangle(0, 0, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1);
            var roundRectR = new RectangleR(rect, dotDis / 2);
            var borderRectR = new RectangleR(bRect, dotDis / 2);

            //画背景
            FillRectangle(e.Graphics, roundRectR, ButtonStyle.ToggleButtonBackColor);

            var x = ButtonStyle.DotDistance;
            dotDis = dotDis - 2 * x - 2 * ButtonStyle.BorderWidth;
            var y = (this.ClientRectangle.Height - dotDis) / 2;
            if (Checked)
            {
                x = this.ClientRectangle.Width - x - dotDis;
            }

            //Dot区域
            _MouseRect = new Rectangle(x, y, dotDis, dotDis);

            _StateColor = ButtonStyle.ToggleOffColor;
            if (Checked)
            {
                _StateColor = ButtonStyle.ToggleOnColor;
            }

            if (EnabledToggle == false)
            {
                _StateColor = ColorTranslator.FromHtml("#c0bfbf");
            }

            //画边框
            DrawPathBorder(e.Graphics, borderRectR, _StateColor, ButtonStyle.BorderWidth);

            //处理dot
            if (_DotFocus)
            {
                _StateColor = ButtonStyle.ToggleOffFocusColor;
                if (Checked)
                {
                    _StateColor = ButtonStyle.ToggleOnFocusColor;
                }
            }

            if (_DotClick)
            {
                var offColor = ButtonStyle.ToggleOffColor;
                var offX = -2;
                if (Checked)
                {
                    offX = 2;
                    offColor = ButtonStyle.ToggleOnColor;
                }
                //画阴影
                var offRect = _MouseRect;
                offRect.Offset(offX, 0);
                using (var brush = new SolidBrush(offColor))
                {
                    e.Graphics.FillEllipse(brush, offRect);
                }
                
            }

            //画圆DOT
            using (var brush = new SolidBrush(_StateColor))
            {
                e.Graphics.FillEllipse(brush, _MouseRect);
            }
            e.Graphics.ResetClip();
        }

        private void FillRectangle(Graphics g, RectangleR roundRect, Color color)
        {
            if (roundRect.Rect.Width <= 0 || roundRect.Rect.Height <= 0)
            {
                return;
            }

            using (GraphicsPath path = roundRect.ToGraphicsBezierPath())
            {
                using (Brush brush = new SolidBrush(color))
                {
                    g.FillPath(brush, path);
                }
            }
        }

        private void DrawPathBorder(Graphics g, RectangleR roundRect, Color color, int borderWidth)
        {
            using (GraphicsPath path = roundRect.ToGraphicsBezierPath())
            {
                using (Pen pen = new Pen(color, borderWidth))
                {
                    g.DrawPath(pen, path);
                }
            }
        }
    }
}
