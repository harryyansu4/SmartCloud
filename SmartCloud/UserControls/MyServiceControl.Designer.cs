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
            this.GoBackButton = new System.Windows.Forms.Button();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.PasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.PGB_PasswordText = new System.Windows.Forms.TextBox();
            this.PGB_NoButton = new System.Windows.Forms.RadioButton();
            this.PGB_YesButton = new System.Windows.Forms.RadioButton();
            this.FileListImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LeftPanel.SuspendLayout();
            this.LeftPanel_Bar.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PasswordGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.panel1);
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
            this.CenterPanel.Controls.Add(this.groupBox2);
            this.CenterPanel.Controls.Add(this.PasswordGroupBox);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(420, 0);
            this.CenterPanel.Margin = new System.Windows.Forms.Padding(5);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(340, 510);
            this.CenterPanel.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(6, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 44);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "可以通过哪些方式搜到自己";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.FlatAppearance.BorderSize = 0;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Location = new System.Drawing.Point(141, 20);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "用户编码";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatAppearance.BorderSize = 0;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(76, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "用户名";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(11, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "IP地址";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // PasswordGroupBox
            // 
            this.PasswordGroupBox.Controls.Add(this.PGB_PasswordText);
            this.PasswordGroupBox.Controls.Add(this.PGB_NoButton);
            this.PasswordGroupBox.Controls.Add(this.PGB_YesButton);
            this.PasswordGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordGroupBox.Location = new System.Drawing.Point(6, 6);
            this.PasswordGroupBox.Name = "PasswordGroupBox";
            this.PasswordGroupBox.Size = new System.Drawing.Size(329, 44);
            this.PasswordGroupBox.TabIndex = 1;
            this.PasswordGroupBox.TabStop = false;
            this.PasswordGroupBox.Text = "是否设置文件下载密码";
            // 
            // PGB_PasswordText
            // 
            this.PGB_PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PGB_PasswordText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PGB_PasswordText.Location = new System.Drawing.Point(99, 20);
            this.PGB_PasswordText.Name = "PGB_PasswordText";
            this.PGB_PasswordText.Size = new System.Drawing.Size(224, 16);
            this.PGB_PasswordText.TabIndex = 2;
            // 
            // PGB_NoButton
            // 
            this.PGB_NoButton.AutoSize = true;
            this.PGB_NoButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PGB_NoButton.FlatAppearance.BorderSize = 0;
            this.PGB_NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGB_NoButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PGB_NoButton.Location = new System.Drawing.Point(56, 18);
            this.PGB_NoButton.Name = "PGB_NoButton";
            this.PGB_NoButton.Size = new System.Drawing.Size(37, 21);
            this.PGB_NoButton.TabIndex = 1;
            this.PGB_NoButton.TabStop = true;
            this.PGB_NoButton.Text = "否";
            this.PGB_NoButton.UseVisualStyleBackColor = true;
            // 
            // PGB_YesButton
            // 
            this.PGB_YesButton.AutoSize = true;
            this.PGB_YesButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PGB_YesButton.FlatAppearance.BorderSize = 0;
            this.PGB_YesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PGB_YesButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PGB_YesButton.Location = new System.Drawing.Point(11, 17);
            this.PGB_YesButton.Name = "PGB_YesButton";
            this.PGB_YesButton.Size = new System.Drawing.Size(37, 21);
            this.PGB_YesButton.TabIndex = 0;
            this.PGB_YesButton.TabStop = true;
            this.PGB_YesButton.Text = "是";
            this.PGB_YesButton.UseVisualStyleBackColor = true;
            // 
            // FileListImageList
            // 
            this.FileListImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FileListImageList.ImageStream")));
            this.FileListImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.FileListImageList.Images.SetKeyName(0, "文件夹.png");
            this.FileListImageList.Images.SetKeyName(1, "文件.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 10);
            this.panel1.TabIndex = 2;
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
            this.CenterPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.PasswordGroupBox.ResumeLayout(false);
            this.PasswordGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox PasswordGroupBox;
        private System.Windows.Forms.TextBox PGB_PasswordText;
        private System.Windows.Forms.RadioButton PGB_NoButton;
        private System.Windows.Forms.RadioButton PGB_YesButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
