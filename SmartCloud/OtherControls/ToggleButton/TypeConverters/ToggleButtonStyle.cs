using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToggleButtonTest.ToggleButton.TypeConverters
{
    /// <summary>
    /// ToggleButton属性样式设置
    /// </summary>
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ToggleButtonStyle
    {
        private Control _control;

        private Color _ToggleOnColor;
        private Color _ToggleOffColor;
        private Color _ToggleButtonBackColor;
        private int _DotDistance;
        private int _BorderWidth;
        private Color _ToggleOnFocusColor;
        private Color _ToggleOffFocusColor;

        public ToggleButtonStyle(Control control)
        {
            this._control = control;
            this._DotDistance = 4;
            this._BorderWidth = 1;
            this._ToggleButtonBackColor = ColorTranslator.FromHtml("#E0E0E0");
            this._ToggleOnColor = ColorTranslator.FromHtml("#6B8E23");
            this._ToggleOffColor = ColorTranslator.FromHtml("#EDF0DE");
            this._ToggleOnFocusColor = ColorTranslator.FromHtml("#6B8E23");
            this._ToggleOffFocusColor = ColorTranslator.FromHtml("#EDF0DE");
        }

        /// <summary>
        /// ToggleButton打开时颜色
        /// </summary>
        [Browsable(true), Description("ToggleButton打开时颜色")]
        public Color ToggleOnColor
        {
            get
            {
                return _ToggleOnColor;
            }
            set
            {
                _ToggleOnColor = value;
                _control.Invalidate();
            }
        }

        /// <summary>
        /// ToggleButton打开时获取焦点颜色
        /// </summary>
        [Browsable(true), Description("ToggleButton打开时获取焦点颜色")]
        public Color ToggleOnFocusColor
        {
            get
            {
                return _ToggleOnFocusColor;
            }
            set
            {
                _ToggleOnFocusColor = value;
                _control.Invalidate();
            }
        }

        /// <summary>
        /// ToggleButton关闭时颜色
        /// </summary>
        [Browsable(true), Description("ToggleButton关闭时颜色")]
        public Color ToggleOffColor
        {
            get
            {
                return _ToggleOffColor;
            }
            set
            {
                _ToggleOffColor = value;
                _control.Invalidate();
            }
        }

        /// <summary>
        /// ToggleButton关闭时获取焦点颜色
        /// </summary>
        [Browsable(true), Description("ToggleButton关闭时获取焦点颜色")]
        public Color ToggleOffFocusColor
        {
            get
            {
                return _ToggleOffFocusColor;
            }
            set
            {
                _ToggleOffFocusColor = value;
                _control.Invalidate();
            }
        }

        /// <summary>
        /// ToggleButton背景色，非BackColor
        /// </summary>
        [Browsable(true), Description("ToggleButton背景色，非BackColor")]
        public Color ToggleButtonBackColor
        {
            get
            {
                return _ToggleButtonBackColor;
            }
            set
            {
                _ToggleButtonBackColor = value;
                _control.Invalidate();
            }
        }

        /// <summary>
        /// 圆点到边界的距离
        /// </summary>
        [Browsable(true), Description("圆点到边界的距离")]
        public int DotDistance
        {
            get
            {
                return _DotDistance;
            }
            set
            {
                if (value <= 0)
                {
                    value = 4;
                }
                _DotDistance = value; _control.Invalidate();
            }
        }

        /// <summary>
        /// 边框大小
        /// </summary>
        [Browsable(true), Description("边框大小")]
        public int BorderWidth
        {
            get
            {
                return _BorderWidth;
            }
            set
            {
                if (value <= 0)
                {
                    value = 1;
                }
                _BorderWidth = value; _control.Invalidate();
            }
        }
    }
}
