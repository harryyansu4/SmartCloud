namespace SmartCloud.UserControls
{
    partial class MyServiceControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyServiceControl));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.FileListView = new System.Windows.Forms.ListView();
            this.LeftPanel_Bar = new System.Windows.Forms.Panel();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.FileListImageList = new System.Windows.Forms.ImageList(this.components);
            this.GoBackButton = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.LeftPanel_Bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.FileListView);
            this.LeftPanel.Controls.Add(this.LeftPanel_Bar);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(5);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(420, 510);
            this.LeftPanel.TabIndex = 0;
            // 
            // FileListView
            // 
            this.FileListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileListView.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileListView.FullRowSelect = true;
            this.FileListView.GridLines = true;
            this.FileListView.HideSelection = false;
            this.FileListView.Location = new System.Drawing.Point(0, 30);
            this.FileListView.Name = "FileListView";
            this.FileListView.Size = new System.Drawing.Size(420, 480);
            this.FileListView.TabIndex = 1;
            this.FileListView.UseCompatibleStateImageBehavior = false;
            this.FileListView.View = System.Windows.Forms.View.Details;
            this.FileListView.DoubleClick += new System.EventHandler(this.FileListView_DoubleClick);
            // 
            // LeftPanel_Bar
            // 
            this.LeftPanel_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            this.LeftPanel_Bar.Controls.Add(this.GoBackButton);
            this.LeftPanel_Bar.Controls.Add(this.FilePathTextBox);
            this.LeftPanel_Bar.Controls.Add(this.BrowseButton);
            this.LeftPanel_Bar.Controls.Add(this.ExecuteButton);
            this.LeftPanel_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftPanel_Bar.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel_Bar.Name = "LeftPanel_Bar";
            this.LeftPanel_Bar.Size = new System.Drawing.Size(420, 30);
            this.LeftPanel_Bar.TabIndex = 0;
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            this.FilePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilePathTextBox.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FilePathTextBox.ForeColor = System.Drawing.Color.Black;
            this.FilePathTextBox.Location = new System.Drawing.Point(40, 6);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(305, 18);
            this.FilePathTextBox.TabIndex = 1;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.BackColor = System.Drawing.Color.OliveDrab;
            this.BrowseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BrowseButton.BackgroundImage")));
            this.BrowseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BrowseButton.FlatAppearance.BorderSize = 0;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BrowseButton.Location = new System.Drawing.Point(350, 2);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(32, 26);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteButton.BackColor = System.Drawing.Color.OliveDrab;
            this.ExecuteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExecuteButton.BackgroundImage")));
            this.ExecuteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExecuteButton.FlatAppearance.BorderSize = 0;
            this.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteButton.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExecuteButton.Location = new System.Drawing.Point(385, 2);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(32, 26);
            this.ExecuteButton.TabIndex = 0;
            this.ExecuteButton.UseVisualStyleBackColor = false;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // CenterPanel
            // 
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(420, 0);
            this.CenterPanel.Margin = new System.Windows.Forms.Padding(5);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(340, 510);
            this.CenterPanel.TabIndex = 1;
            // 
            // FileListImageList
            // 
            this.FileListImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FileListImageList.ImageStream")));
            this.FileListImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.FileListImageList.Images.SetKeyName(0, "文件夹.png");
            this.FileListImageList.Images.SetKeyName(1, "文件.png");
            // 
            // GoBackButton
            // 
            this.GoBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBackButton.BackColor = System.Drawing.Color.OliveDrab;
            this.GoBackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoBackButton.BackgroundImage")));
            this.GoBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoBackButton.FlatAppearance.BorderSize = 0;
            this.GoBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackButton.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GoBackButton.Location = new System.Drawing.Point(3, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(32, 26);
            this.GoBackButton.TabIndex = 3;
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // MyServiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MyServiceControl";
            this.Size = new System.Drawing.Size(760, 510);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel_Bar.ResumeLayout(false);
            this.LeftPanel_Bar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Panel LeftPanel_Bar;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.ListView FileListView;
        private System.Windows.Forms.ImageList FileListImageList;
        private System.Windows.Forms.Button GoBackButton;
    }
}
