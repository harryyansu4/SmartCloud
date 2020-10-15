using SmartCloud.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCloud
{
    public partial class MainWindow : Form
    {
        /// <summary>
        /// 是否可移动窗体
        /// </summary>
        private bool Moving = false;
        /// <summary>
        /// 窗体上一个位置
        /// </summary>
        private Point OldMouseLocation;
        /// <summary>
        /// 导航列表区域的初始宽度
        /// </summary>
        private int NLDefaultWidth = 160;

        /// <summary>
        /// 用于存储已创建的UserControl对象
        /// </summary>
        public Dictionary<string, UserControl> ControlCacheDic = new Dictionary<string, UserControl>();

        public MainWindow()
        {
            InitializeComponent();
            // 初始化首次启动程序时的UserControl界面，并储存在缓存字典中
            CommonServiceControl csControl = new CommonServiceControl();
            this.AddUserControlToPanel(csControl);
            ControlCacheDic.Add("CommonServiceControl", csControl);
            // 初始化导航列表区域的宽度
            this.NavigateList.Width = NLDefaultWidth;
        }

        /// <summary>
        /// 点击导航列表中的按钮时移动选中效果滑块
        /// </summary>
        /// <param name="btn"></param>
        private void MoveCheckedSlider(Control btn)
        {
            if (btn != null && btn is Button)
            {
                CheckedSlider.Top = btn.Top;
                CheckedSlider.Height = btn.Height;
            }
        }

        /// <summary>
        /// 将传入的用户控件展示在UserControlsPanel中
        /// </summary>
        /// <param name="c"></param>
        private void AddUserControlToPanel(Control c)
        {
            if (c != null && c is UserControl)
            {
                c.Dock = DockStyle.Fill;
                this.OperateSpace_Center.Controls.Clear();
                this.OperateSpace_Center.Controls.Add(c);
            }
        }

        /// <summary>
        /// 退出按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        /// <summary>
        /// 最大化按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        /// <summary>
        /// 最小化按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        #region 窗体移动
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                return;
            }
            this.OldMouseLocation = e.Location;
            this.Moving = true;
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            this.Moving = false;
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Moving)
            {
                Point newPoint = new Point(e.Location.X - OldMouseLocation.X, e.Location.Y - OldMouseLocation.Y);
                this.Location += new Size(newPoint);
            }
        }
        #endregion

        /// <summary>
        /// 标题栏双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        /// <summary>
        /// 社区服务按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommonServiceButton_Click(object sender, EventArgs e)
        {
            // 将选中效果滑块移动至当前按钮
            MoveCheckedSlider(this.CommonServiceButton);
            // 优先从公共字典中获取UserControl
            CommonServiceControl csControl;
            if (ControlCacheDic.ContainsKey("CommonServiceControl"))
            {
                csControl = ControlCacheDic["CommonServiceControl"] as CommonServiceControl;
            }
            else
            {
                csControl = new CommonServiceControl();
                this.ControlCacheDic.Add("CommonServiceControl", csControl);
            }
            // 加载界面
            this.AddUserControlToPanel(csControl);
        }

        /// <summary>
        /// 我的服务按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyServiceButton_Click(object sender, EventArgs e)
        {
            // 将选中效果滑块移动至当前按钮
            MoveCheckedSlider(this.MyServiceButton);
            // 优先从公共字典中获取UserControl
            MyServiceControl msControl;
            if (ControlCacheDic.ContainsKey("MyServiceControl"))
            {
                msControl = ControlCacheDic["MyServiceControl"] as MyServiceControl;
            }
            else
            {
                msControl = new MyServiceControl();
                this.ControlCacheDic.Add("MyServiceControl", msControl);
            }
            // 加载界面
            this.AddUserControlToPanel(msControl);
        }

        /// <summary>
        /// 导航列表控制按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavigateControlButton_Click(object sender, EventArgs e)
        {
            // 实现导航列表的收缩和展开
            if (NavigateList.Width == NLDefaultWidth)
                NavigateList.Width = 50;
            else
                NavigateList.Width = NLDefaultWidth;
        }
    }
}
