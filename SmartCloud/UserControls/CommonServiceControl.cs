using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCloud.UserControls
{
    public partial class CommonServiceControl : UserControl
    {
        

        public CommonServiceControl()
        {
            InitializeComponent();
            // 初始化ListView的列表头
            ColumnHeader chForListView = new ColumnHeader();
            chForListView.Width = 280;
            chForListView.Text = "文件名";
            chForListView.TextAlign = HorizontalAlignment.Left;// 设置列的对齐方式
            this.FileListView.Columns.Add(chForListView);
            
        }
    }
}
