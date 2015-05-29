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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.enter = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconCM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.information = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(72, 114);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(120, 21);
            this.passwordBox.TabIndex = 0;
            this.passwordBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.iconCM.Name = "iconCM";
            this.iconCM.Size = new System.Drawing.Size(61, 4);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.NotifyIcon icon;
        private System.Windows.Forms.ContextMenuStrip iconCM;
        private System.Windows.Forms.Label information;
    }
}

