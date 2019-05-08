namespace CSkinDemo
{
    partial class Form
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(4, 34);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(992, 562);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("http://sherry.cf/music/", System.UriKind.Absolute);
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "雪莉音乐";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CanResize = false;
            this.CaptionBackColorBottom = System.Drawing.Color.Empty;
            this.CaptionBackColorTop = System.Drawing.Color.Empty;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaptionHeight = 30;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.CloseBoxSize = new System.Drawing.Size(15, 15);
            this.CloseDownBack = global::SherryMusic.Properties.Resources.winfo_icon_关闭;
            this.CloseMouseBack = global::SherryMusic.Properties.Resources.winfo_icon_关闭;
            this.CloseNormlBack = global::SherryMusic.Properties.Resources.winfo_icon_关闭;
            this.ControlBoxOffset = new System.Drawing.Point(10, 10);
            this.ControlBoxSpace = 10;
            this.Controls.Add(this.webBrowser);
            this.DropBack = false;
            this.EffectWidth = 0;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ICoOffset = new System.Drawing.Point(5, 0);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaxDownBack = global::SherryMusic.Properties.Resources.winfo_icon_最大化;
            this.MaxMouseBack = global::SherryMusic.Properties.Resources.winfo_icon_最大化;
            this.MaxNormlBack = global::SherryMusic.Properties.Resources.winfo_icon_最大化;
            this.MaxSize = new System.Drawing.Size(15, 15);
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = global::SherryMusic.Properties.Resources.winfo_icon_最小化;
            this.MiniNormlBack = global::SherryMusic.Properties.Resources.winfo_icon_最小化;
            this.MiniSize = new System.Drawing.Size(15, 15);
            this.Mobile = CCWin.MobileStyle.TitleMobile;
            this.Name = "Form";
            this.RestoreDownBack = global::SherryMusic.Properties.Resources.winfo_icon_最大化;
            this.RestoreMouseBack = global::SherryMusic.Properties.Resources.winfo_icon_最大化;
            this.RestoreNormlBack = global::SherryMusic.Properties.Resources.winfo_icon_最大化;
            this.RoundStyle = CCWin.SkinClass.RoundStyle.Top;
            this.ShowBorder = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "雪莉音乐";
            this.TitleOffset = new System.Drawing.Point(3, 3);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
    }
}

