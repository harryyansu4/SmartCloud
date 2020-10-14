namespace SmartCloud
{
    partial class MainWindow
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MaximizeButton = new System.Windows.Forms.Button();
            this.NavigateList = new System.Windows.Forms.Panel();
            this.NavigateControl_Top = new System.Windows.Forms.Panel();
            this.OperateSpace = new System.Windows.Forms.Panel();
            this.InformationBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.TitleBar.SuspendLayout();
            this.NavigateList.SuspendLayout();
            this.NavigateControl_Top.SuspendLayout();
            this.OperateSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.OliveDrab;
            this.TitleBar.Controls.Add(this.MinimizeButton);
            this.TitleBar.Controls.Add(this.ExitButton);
            this.TitleBar.Controls.Add(this.MaximizeButton);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(5);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(920, 30);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDoubleClick);
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(811, 3);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(26, 26);
            this.MinimizeButton.TabIndex = 5;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(884, 2);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(26, 26);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MaximizeButton.BackgroundImage")));
            this.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.Location = new System.Drawing.Point(849, 2);
            this.MaximizeButton.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(26, 26);
            this.MaximizeButton.TabIndex = 4;
            this.MaximizeButton.UseVisualStyleBackColor = true;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // NavigateList
            // 
            this.NavigateList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(229)))), ((int)(((byte)(198)))));
            this.NavigateList.Controls.Add(this.NavigateControl_Top);
            this.NavigateList.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigateList.Location = new System.Drawing.Point(0, 30);
            this.NavigateList.Margin = new System.Windows.Forms.Padding(5);
            this.NavigateList.Name = "NavigateList";
            this.NavigateList.Size = new System.Drawing.Size(160, 550);
            this.NavigateList.TabIndex = 1;
            // 
            // NavigateControl_Top
            // 
            this.NavigateControl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(203)))), ((int)(((byte)(64)))));
            this.NavigateControl_Top.Controls.Add(this.button1);
            this.NavigateControl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigateControl_Top.Location = new System.Drawing.Point(0, 0);
            this.NavigateControl_Top.Margin = new System.Windows.Forms.Padding(5);
            this.NavigateControl_Top.Name = "NavigateControl_Top";
            this.NavigateControl_Top.Size = new System.Drawing.Size(160, 40);
            this.NavigateControl_Top.TabIndex = 0;
            // 
            // OperateSpace
            // 
            this.OperateSpace.Controls.Add(this.InformationBar);
            this.OperateSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OperateSpace.Location = new System.Drawing.Point(160, 30);
            this.OperateSpace.Margin = new System.Windows.Forms.Padding(5);
            this.OperateSpace.Name = "OperateSpace";
            this.OperateSpace.Size = new System.Drawing.Size(760, 550);
            this.OperateSpace.TabIndex = 2;
            // 
            // InformationBar
            // 
            this.InformationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.InformationBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.InformationBar.Location = new System.Drawing.Point(0, 0);
            this.InformationBar.Margin = new System.Windows.Forms.Padding(5);
            this.InformationBar.Name = "InformationBar";
            this.InformationBar.Size = new System.Drawing.Size(760, 40);
            this.InformationBar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(120, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 28);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 580);
            this.Controls.Add(this.OperateSpace);
            this.Controls.Add(this.NavigateList);
            this.Controls.Add(this.TitleBar);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleBar.ResumeLayout(false);
            this.NavigateList.ResumeLayout(false);
            this.NavigateControl_Top.ResumeLayout(false);
            this.OperateSpace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button MaximizeButton;
        private System.Windows.Forms.Panel NavigateList;
        private System.Windows.Forms.Panel OperateSpace;
        private System.Windows.Forms.Panel InformationBar;
        private System.Windows.Forms.Panel NavigateControl_Top;
        private System.Windows.Forms.Button button1;
    }
}

