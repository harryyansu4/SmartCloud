using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using SmartCloud.UserControls.Function;
using System.Threading;

namespace SmartCloud.UserControls
{
    public partial class MyServiceControl : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private List<string> FilePathList = new List<string>();
        /// <summary>
        /// ListView信息回显委托
        /// </summary>
        /// <param name="value"></param>
        private delegate void ShowInfoDelegate(ListViewItem listViewItem);

        /// <summary>
        /// 总文件路径
        /// </summary>
        public string FilePath = "";
        /// <summary>
        /// 线程队列
        /// </summary>
        public ConcurrentQueue<string> ProcessInfoQueue;

        public MyServiceControl()
        {
            InitializeComponent();
            // 实例化线程队列
            ProcessInfoQueue = new ConcurrentQueue<string>();
        }

        public void ShowInfoOnTreeView()
        {
            bool processControl = true;// 循环控制
            while (processControl)
            {
                if (this.ProcessInfoQueue.IsEmpty)
                    continue;
                // 从线程队列中获取信息
                string infoStr = "";
                bool successFlag = this.ProcessInfoQueue.TryDequeue(out infoStr);
                if (successFlag)
                {
                    // 是否未结束
                    if (!"process is finished".Equals(infoStr))
                    {
                        FilePathList.Add(infoStr);
                    }
                    else
                    {
                        processControl = false;
                    }
                }
            }

            if (this.FilePathList.Count <= 0)
                return;

            for (int i = 0; i <= FilePathList.Count - 1; i++)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = FilePathList[i];

                if (this.FileListView.InvokeRequired)
                    this.FileListView.BeginInvoke(new ShowInfoDelegate(ShowInfo), new object[] { listViewItem });
                else
                    this.FileListView.Items.Add(listViewItem);
            }
            MessageBox.Show("结束");
        }

        private void ShowInfo(ListViewItem lvItem)
        {
            this.FileListView.Items.Add(lvItem);
        }

        /// <summary>
        /// 浏览按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            // 实例化文件夹浏览弹框
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            // 弹框标题
            fbDialog.Description = "请选择文件夹路径";
            // 弹框初始路径（桌面）
            if (!string.IsNullOrEmpty(FilePath))
                fbDialog.SelectedPath = this.FilePath;
            else
                fbDialog.RootFolder = Environment.SpecialFolder.Desktop;

            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                // 记录选择的文件夹路径并回显到路径文本框
                this.FilePath = fbDialog.SelectedPath;
                if (!string.IsNullOrEmpty(FilePath))
                {
                    this.FilePathTextBox.Text = this.FilePath;
                }
            }
        }

        /// <summary>
        /// 执行按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilePath))
            {
                MessageBox.Show("未选择文件路径信息...");
                return;
            }
            // 开启TreeView信息回显执行线程
            Thread t = new Thread(new ThreadStart(ShowInfoOnTreeView));
            t.Start();
            // 实例化文件操作类，并开始执行
            MyServiceTask msTask = new MyServiceTask();
            msTask.Start(this.FilePath, this.ProcessInfoQueue);

        }
    }
}
