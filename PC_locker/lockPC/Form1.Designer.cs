namespace LockPC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.tip = new System.Windows.Forms.Label();
            this.kill_timer = new System.Windows.Forms.Timer(this.components);
            this.enter = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconCM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.模式1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.information = new System.Windows.Forms.Label();
            this.more_try_timer = new System.Windows.Forms.Timer(this.components);
            this.iconCM.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(72, 114);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(120, 21);
            this.passwordBox.TabIndex = 0;
            this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordBox_KeyDown);
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tip.Location = new System.Drawing.Point(69, 94);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(164, 17);
            this.tip.TabIndex = 1;
            this.tip.Text = "请输入密码或者你可以消失了";
            this.tip.Click += new System.EventHandler(this.label1_Click);
            // 
            // kill_timer
            // 
            this.kill_timer.Interval = 10;
            this.kill_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enter.Location = new System.Drawing.Point(72, 141);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(80, 22);
            this.enter.TabIndex = 2;
            this.enter.Text = "进入";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // icon
            // 
            this.icon.ContextMenuStrip = this.iconCM;
            this.icon.Icon = ((System.Drawing.Icon)(resources.GetObject("icon.Icon")));
            this.icon.Text = "PC_Locker";
            this.icon.Visible = true;
            this.icon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.icon_MouseDoubleClick);
            // 
            // iconCM
            // 
            this.iconCM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.模式1ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.iconCM.Name = "iconCM";
            this.iconCM.Size = new System.Drawing.Size(108, 70);
            // 
            // 模式1ToolStripMenuItem
            // 
            this.模式1ToolStripMenuItem.Name = "模式1ToolStripMenuItem";
            this.模式1ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.模式1ToolStripMenuItem.Text = "模式1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // information
            // 
            this.information.AutoSize = true;
            this.information.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.information.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.information.Location = new System.Drawing.Point(70, 166);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(0, 20);
            this.information.TabIndex = 3;
            this.information.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // more_try_timer
            // 
            this.more_try_timer.Tick += new System.EventHandler(this.more_try_timer_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.information);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.passwordBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.iconCM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Timer kill_timer;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.NotifyIcon icon;
        private System.Windows.Forms.ContextMenuStrip iconCM;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 模式1ToolStripMenuItem;
        private System.Windows.Forms.Timer more_try_timer;
    }
}

