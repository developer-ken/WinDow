namespace WindDow
{
    partial class ShowcaseWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清空ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绿幕背景BackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加粗选中BoldenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑白切换WhiteBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高级字体设置FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全局设置GlobalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪贴板视图模式ClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(556, 454);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空ClearToolStripMenuItem,
            this.绿幕背景BackgroundToolStripMenuItem,
            this.加粗选中BoldenToolStripMenuItem,
            this.黑白切换WhiteBlackToolStripMenuItem,
            this.高级字体设置FontToolStripMenuItem,
            this.全局设置GlobalToolStripMenuItem,
            this.剪贴板视图模式ClipboardToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(227, 158);
            // 
            // 清空ClearToolStripMenuItem
            // 
            this.清空ClearToolStripMenuItem.Name = "清空ClearToolStripMenuItem";
            this.清空ClearToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.清空ClearToolStripMenuItem.Text = "清空(&Clear)";
            this.清空ClearToolStripMenuItem.Click += new System.EventHandler(this.清空ClearToolStripMenuItem_Click);
            // 
            // 绿幕背景BackgroundToolStripMenuItem
            // 
            this.绿幕背景BackgroundToolStripMenuItem.Name = "绿幕背景BackgroundToolStripMenuItem";
            this.绿幕背景BackgroundToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.绿幕背景BackgroundToolStripMenuItem.Text = "绿幕背景(&Background)";
            this.绿幕背景BackgroundToolStripMenuItem.Click += new System.EventHandler(this.绿幕背景BackgroundToolStripMenuItem_Click);
            // 
            // 加粗选中BoldenToolStripMenuItem
            // 
            this.加粗选中BoldenToolStripMenuItem.Name = "加粗选中BoldenToolStripMenuItem";
            this.加粗选中BoldenToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.加粗选中BoldenToolStripMenuItem.Text = "加粗选中(&Bolden)";
            this.加粗选中BoldenToolStripMenuItem.Click += new System.EventHandler(this.加粗选中BoldenToolStripMenuItem_Click);
            // 
            // 黑白切换WhiteBlackToolStripMenuItem
            // 
            this.黑白切换WhiteBlackToolStripMenuItem.Name = "黑白切换WhiteBlackToolStripMenuItem";
            this.黑白切换WhiteBlackToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.黑白切换WhiteBlackToolStripMenuItem.Text = "黑白切换(&White Black)";
            this.黑白切换WhiteBlackToolStripMenuItem.Click += new System.EventHandler(this.黑白切换WhiteBlackToolStripMenuItem_Click);
            // 
            // 高级字体设置FontToolStripMenuItem
            // 
            this.高级字体设置FontToolStripMenuItem.Name = "高级字体设置FontToolStripMenuItem";
            this.高级字体设置FontToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.高级字体设置FontToolStripMenuItem.Text = "高级字体设置(&Font)";
            this.高级字体设置FontToolStripMenuItem.Click += new System.EventHandler(this.高级字体设置FontToolStripMenuItem_Click);
            // 
            // 全局设置GlobalToolStripMenuItem
            // 
            this.全局设置GlobalToolStripMenuItem.Enabled = false;
            this.全局设置GlobalToolStripMenuItem.Name = "全局设置GlobalToolStripMenuItem";
            this.全局设置GlobalToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.全局设置GlobalToolStripMenuItem.Text = "全局设置(&Global)";
            // 
            // 剪贴板视图模式ClipboardToolStripMenuItem
            // 
            this.剪贴板视图模式ClipboardToolStripMenuItem.CheckOnClick = true;
            this.剪贴板视图模式ClipboardToolStripMenuItem.Name = "剪贴板视图模式ClipboardToolStripMenuItem";
            this.剪贴板视图模式ClipboardToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.剪贴板视图模式ClipboardToolStripMenuItem.Text = "剪贴板视图模式(&Clipboard)";
            this.剪贴板视图模式ClipboardToolStripMenuItem.CheckedChanged += new System.EventHandler(this.剪贴板视图模式ClipboardToolStripMenuItem_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ShowcaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(556, 454);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ShowcaseWindow";
            this.Text = "展示窗口 - 此窗口被OBS捕获";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowcaseWindow_FormClosed);
            this.Load += new System.EventHandler(this.ShowcaseWindow_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清空ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绿幕背景BackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加粗选中BoldenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黑白切换WhiteBlackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高级字体设置FontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem 全局设置GlobalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪贴板视图模式ClipboardToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
