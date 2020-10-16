namespace SmartCloud.UserControls
{
    partial class CommonServiceControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommonServiceControl));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.FileListView = new System.Windows.Forms.ListView();
            this.LeftPanel_Bar = new System.Windows.Forms.Panel();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.UserTabControl = new System.Windows.Forms.TabControl();
            this.CommonTabPage = new System.Windows.Forms.TabPage();
            this.FocusTabPage = new System.Windows.Forms.TabPage();
            this.CenterPanel_Bar = new System.Windows.Forms.Panel();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CenterPanel_Control = new System.Windows.Forms.Panel();
            this.ControlButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.LeftPanel_Bar.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            this.UserTabControl.SuspendLayout();
            this.CenterPanel_Bar.SuspendLayout();
            this.CenterPanel_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.FileListView);
            this.LeftPanel.Controls.Add(this.LeftPanel_Bar);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(560, 510);
            this.LeftPanel.TabIndex = 0;
            // 
            // FileListView
            // 
            this.FileListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileListView.FullRowSelect = true;
            this.FileListView.GridLines = true;
            this.FileListView.HideSelection = false;
            this.FileListView.Location = new System.Drawing.Point(0, 0);
            this.FileListView.Name = "FileListView";
            this.FileListView.Size = new System.Drawing.Size(560, 480);
            this.FileListView.TabIndex = 1;
            this.FileListView.UseCompatibleStateImageBehavior = false;
            this.FileListView.View = System.Windows.Forms.View.Details;
            // 
            // LeftPanel_Bar
            // 
            this.LeftPanel_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            this.LeftPanel_Bar.Controls.Add(this.button2);
            this.LeftPanel_Bar.Controls.Add(this.button1);
            this.LeftPanel_Bar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LeftPanel_Bar.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LeftPanel_Bar.Location = new System.Drawing.Point(0, 480);
            this.LeftPanel_Bar.Name = "LeftPanel_Bar";
            this.LeftPanel_Bar.Size = new System.Drawing.Size(560, 30);
            this.LeftPanel_Bar.TabIndex = 0;
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.UserTabControl);
            this.CenterPanel.Controls.Add(this.CenterPanel_Bar);
            this.CenterPanel.Controls.Add(this.CenterPanel_Control);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(560, 0);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(200, 510);
            this.CenterPanel.TabIndex = 1;
            // 
            // UserTabControl
            // 
            this.UserTabControl.Controls.Add(this.CommonTabPage);
            this.UserTabControl.Controls.Add(this.FocusTabPage);
            this.UserTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserTabControl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserTabControl.Location = new System.Drawing.Point(10, 30);
            this.UserTabControl.Name = "UserTabControl";
            this.UserTabControl.SelectedIndex = 0;
            this.UserTabControl.Size = new System.Drawing.Size(190, 480);
            this.UserTabControl.TabIndex = 2;
            // 
            // CommonTabPage
            // 
            this.CommonTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.CommonTabPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CommonTabPage.Location = new System.Drawing.Point(4, 26);
            this.CommonTabPage.Name = "CommonTabPage";
            this.CommonTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CommonTabPage.Size = new System.Drawing.Size(182, 450);
            this.CommonTabPage.TabIndex = 0;
            this.CommonTabPage.Text = "社区";
            // 
            // FocusTabPage
            // 
            this.FocusTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.FocusTabPage.Location = new System.Drawing.Point(4, 26);
            this.FocusTabPage.Name = "FocusTabPage";
            this.FocusTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FocusTabPage.Size = new System.Drawing.Size(182, 450);
            this.FocusTabPage.TabIndex = 1;
            this.FocusTabPage.Text = "关注";
            // 
            // CenterPanel_Bar
            // 
            this.CenterPanel_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(222)))));
            this.CenterPanel_Bar.Controls.Add(this.SearchTextBox);
            this.CenterPanel_Bar.Controls.Add(this.SearchButton);
            this.CenterPanel_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.CenterPanel_Bar.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CenterPanel_Bar.Location = new System.Drawing.Point(10, 0);
            this.CenterPanel_Bar.Name = "CenterPanel_Bar";
            this.CenterPanel_Bar.Size = new System.Drawing.Size(190, 30);
            this.CenterPanel_Bar.TabIndex = 1;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextBox.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchTextBox.Location = new System.Drawing.Point(6, 6);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(150, 18);
            this.SearchTextBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.BackColor = System.Drawing.Color.OliveDrab;
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(161, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(26, 26);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // CenterPanel_Control
            // 
            this.CenterPanel_Control.BackColor = System.Drawing.Color.White;
            this.CenterPanel_Control.Controls.Add(this.ControlButton);
            this.CenterPanel_Control.Dock = System.Windows.Forms.DockStyle.Left;
            this.CenterPanel_Control.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CenterPanel_Control.Location = new System.Drawing.Point(0, 0);
            this.CenterPanel_Control.Name = "CenterPanel_Control";
            this.CenterPanel_Control.Size = new System.Drawing.Size(10, 510);
            this.CenterPanel_Control.TabIndex = 0;
            // 
            // ControlButton
            // 
            this.ControlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(203)))), ((int)(((byte)(64)))));
            this.ControlButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ControlButton.BackgroundImage")));
            this.ControlButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ControlButton.FlatAppearance.BorderSize = 0;
            this.ControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlButton.Location = new System.Drawing.Point(0, 205);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(10, 40);
            this.ControlButton.TabIndex = 2;
            this.ControlButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(468, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(514, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "下载";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // CommonServiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CommonServiceControl";
            this.Size = new System.Drawing.Size(760, 510);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel_Bar.ResumeLayout(false);
            this.CenterPanel.ResumeLayout(false);
            this.UserTabControl.ResumeLayout(false);
            this.CenterPanel_Bar.ResumeLayout(false);
            this.CenterPanel_Bar.PerformLayout();
            this.CenterPanel_Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Panel LeftPanel_Bar;
        private System.Windows.Forms.ListView FileListView;
        private System.Windows.Forms.TabControl UserTabControl;
        private System.Windows.Forms.TabPage CommonTabPage;
        private System.Windows.Forms.TabPage FocusTabPage;
        private System.Windows.Forms.Panel CenterPanel_Bar;
        private System.Windows.Forms.Panel CenterPanel_Control;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
