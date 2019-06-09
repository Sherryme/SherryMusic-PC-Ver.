using System;
using System.ComponentModel;
using System.Windows.Forms;
using CCWin;

namespace SherryMusic
{
    public partial class Form : CCSkinMain
    {
        public Form()
        {            
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //关闭程序
            }
            else
            {
                e.Cancel = true;//保持状态
                this.Hide(); //隐藏窗体 
                this.ShowInTaskbar = false;//图标不显示在任务栏上 
            }
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;
        }
    }
}
