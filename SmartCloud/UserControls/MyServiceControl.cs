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
        /// 读取到的文件全路径集合
        /// </summary>
        private List<string> FilePathList = new List<string>();
        /// <summary>
        /// ListView信息回显委托
        /// </summary>
        /// <param name="value"></param>
        private delegate void ShowInfoDelegate(ListViewItem listViewItem);
        /// <summary>
        /// 文件根路径（用于校验当前路径是否越过根路径）
        /// </summary>
        private string RootFilePath = "";

        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath = "";
        /// <summary>
        /// 线程队列
        /// </summary>
        public ConcurrentQueue<string> ProcessInfoQueue;

        public MyServiceControl()
        {
            InitializeComponent();
            // 初始化ListView的列表头
            ColumnHeader chForListView = new ColumnHeader();
            chForListView.Width = 280;
            chForListView.Text = "文件名";
            chForListView.TextAlign = HorizontalAlignment.Left;// 设置列的对齐方式
            this.FileListView.Columns.Add(chForListView);
            // 将listView的图标集与imageList1绑定
            this.FileListView.SmallImageList = this.FileListImageList;
            // 实例化线程队列
            ProcessInfoQueue = new ConcurrentQueue<string>();
        }

        #region 开始执行时FileListView信息回显的线程执行区域
        public void ShowInfoOnTreeView()
        {
            this.FilePathList.Clear();
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
                        FilePathList.Add(infoStr);
                    else
                        processControl = false;
                }
            }
            if (this.FilePathList.Count <= 0)
                return;
            // 文件路径转换
            List<ListViewItem> itemList = TransforFilePath(this.FilePath, this.FilePathList);
            // 界面回显
            for (int i = 0; i <= itemList.Count - 1; i++)
            {
                if (this.FileListView.InvokeRequired)
                    this.FileListView.BeginInvoke(new ShowInfoDelegate(ShowInfo), new object[] { itemList[i] });
                else
                    this.FileListView.Items.Add(itemList[i]);
            }
        }

        private void ShowInfo(ListViewItem lvItem)
        {
            this.FileListView.Items.Add(lvItem);
        }
        #endregion

        /// <summary>
        /// 从集合中获取到当前路径下的文件和文件夹，并形成列信息
        /// </summary>
        /// <param name="filePath">上一级全路径名</param>
        /// <param name="filePathList">待转换的全路径名集合</param>
        /// <returns></returns>
        private List<ListViewItem> TransforFilePath(string filePath, List<string> filePathList)
        {
            List<ListViewItem> itemList = new List<ListViewItem>();
            // 用于记录可回显的文件和文件夹名称
            List<string> checkList = new List<string>();
            for (int i = 0; i <= filePathList.Count - 1; i++)
            {
                // 获取当前目录下的文件和文件夹
                string newFilePath = filePathList[i].Replace(filePath, "");
                // 集合中的路径可能和上一级路径相同，导致替换完变成空字符创
                if (newFilePath == null || "".Equals(newFilePath))
                    continue;
                string[] strs = newFilePath.Substring(1, newFilePath.Length - 1).Split('\\');
                // 排除重复的回显名称
                if (checkList.Contains(strs[0]))
                    continue;
                checkList.Add(strs[0]);
                // 创建列
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = strs[0];// 显示名称
                listViewItem.Tag = filePath + "\\" + strs[0];// 记录当前文件或文件夹的全路径名
                // 图片标识、名称
                if (strs.Length <= 1 && strs[0].Contains("."))
                {
                    listViewItem.Name = "file";
                    listViewItem.ImageIndex = 1;
                }
                else
                {
                    listViewItem.Name = "directory";
                    listViewItem.ImageIndex = 0;
                }
                itemList.Add(listViewItem);
            }
            return itemList;
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
                    this.RootFilePath = this.FilePath;
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
            if (!string.IsNullOrEmpty(RootFilePath) && !FilePath.Equals(RootFilePath))
            {
                MessageBoxButtons messageBtn = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("再次执行将更改初始目录，是否继续...", "目录更改提示", messageBtn);
                if (dr == DialogResult.OK)
                    this.RootFilePath = this.FilePath;
                else
                    return;
            }
            this.FileListView.Items.Clear();
            // 开启TreeView信息回显执行线程
            Thread t = new Thread(new ThreadStart(ShowInfoOnTreeView));
            t.Start();
            // 实例化文件操作类，并开始执行
            MyServiceTask msTask = new MyServiceTask();
            msTask.Start(this.FilePath, this.ProcessInfoQueue);

        }

        /// <summary>
        /// FileListView信息双击事件（双击进入文件夹）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileListView_DoubleClick(object sender, EventArgs e)
        {
            // 获取当前选中的行信息
            ListViewItem focusItem = this.FileListView.FocusedItem;
            if (focusItem == null)
                return;
            if ("file".Equals(focusItem.Name))
                return;
            // 获取当前全路径名
            string filePath = focusItem.Tag.ToString();
            // 回显路径信息，并更新文件路径
            this.FilePathTextBox.Text = filePath;
            this.FilePath = filePath;
            // 从总文件路径集合中筛选出当前文件夹相关的路径信息，并储存
            List<string> childFileList = new List<string>();
            for (int i = 0; i <= FilePathList.Count - 1; i++)
            {
                if (FilePathList[i].Contains(filePath))
                    childFileList.Add(FilePathList[i]);
            }
            this.FileListView.Items.Clear();
            // 文件路径转换，并回显
            this.FileListView.BeginUpdate();
            List<ListViewItem> itemList = TransforFilePath(filePath, childFileList);
            foreach (ListViewItem item in itemList)
            {
                this.FileListView.Items.Add(item);
            }
            this.FileListView.EndUpdate();
        }

        /// <summary>
        /// 返回按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            // 路径校验
            if (FilePath.Equals(RootFilePath))
            {
                MessageBox.Show("已返回到初始目录，无法再返回！");
                return;
            }
            // 获取上一级路径，并跟新路径信息
            string[] strs = this.FilePath.Split('\\');
            string newFilePath = "";
            for (int i = 0; i < strs.Length - 1; i++)
            {
                newFilePath = newFilePath + strs[i] + "\\";
            }
            this.FilePath = newFilePath.Substring(0, newFilePath.Length - 1);
            this.FilePathTextBox.Text = this.FilePath;
            // 从总文件路径集合中筛选出当前文件夹相关的路径信息，并储存
            List<string> childFileList = new List<string>();
            for (int i = 0; i <= FilePathList.Count - 1; i++)
            {
                if (FilePathList[i].Contains(FilePath))
                    childFileList.Add(FilePathList[i]);
            }
            this.FileListView.Items.Clear();
            // 文件路径转换，并回显
            this.FileListView.BeginUpdate();
            List<ListViewItem> itemList = TransforFilePath(FilePath, childFileList);
            foreach (ListViewItem item in itemList)
            {
                this.FileListView.Items.Add(item);
            }
            this.FileListView.EndUpdate();
        }
    }
}
