using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockPC
{
    public partial class Form1 : Form
    {
        private string password;
        //当前窗口长度
        private int height;
        //当前窗口宽度
        private int width;
        //计数器：用于记录某次动作的发生次数
        private int times = 0;

        [DllImport("user32.dll")]

        private static extern IntPtr GetForegroundWindow();
        public Form1()
        {
            InitializeComponent();
        
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //部分1：初始化（定时器，置顶）
            //窗口最大化
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            //启动定时器
            this.kill_timer.Enabled = true;

            //部分2：设置窗口布局
            //获取当前窗口大小
            height = this.Height;
            width = this.Width;
            //提示信息位置
            this.tip.Location = new Point(width / 2 - this.tip.Width / 2, height / 2 - 40);
            //密码框位置：当前窗口大小-0.5*密码框长度
            this.passwordBox.Location = new Point(width / 2 - this.passwordBox.Width / 2, height / 2 - this.passwordBox.Height / 2);
            //确定按钮位置
            this.enter.Location = new Point(width / 2 - this.enter.Width / 2, height / 2 + this.passwordBox.Height + this.passwordBox.Height / 2);
            
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //记录密码输入次数
            times++;
            //当密码输入为空时，显示提示
            if (this.passwordBox.Text == "")
            {
                //密码不正确时显示提示信息
                this.information.Text = "密码不能为空!";
                this.information.Location = new Point(width / 2 - this.information.Width / 2, 30);
            }
            else if ("q87623460" == this.passwordBox.Text)
            {
                //窗口最小化
                this.WindowState = FormWindowState.Minimized;
                //隐藏任务栏区图标 
                this.ShowInTaskbar = false;
                //托盘显示

                //关闭阻止任务管理器的定时器
                this.kill_timer.Enabled = false;

            }
            else 
            {
                
                switch(times)
                {
                    //当密码输入次数小于3次时，判断为手误
                    case 1:
                    case 2:
                        //密码不正确时显示提示信息
                        this.information.Text = "密码不正确!";
                        this.information.Location = new Point(width / 2 - this.information.Width / 2, 30);
                        //将密码框清空
                        this.passwordBox.Text = "";
                        break;
                    case 3:
                        //密码不正确时显示提示信息
                        this.information.Text = "密码不正确!已启动防御模式，已关闭输入系统，你可以离开了！";
                        this.information.Location = new Point(width / 2 - this.information.Width / 2, 30);
                        //将密码框清空
                        this.passwordBox.Text = "";

                        //大于3次判定为恶意输入，进入非主人模式，启动定时器，关闭输入框10秒
                        //关闭输入框
                        this.passwordBox.Enabled = false;
                        //设置定时器
                        this.more_try_timer.Interval = 1000*10;
                        this.more_try_timer.Enabled = true;
                        //停用窗口默认按钮，防止在进入关闭输入框状态按下回车使times计数值增加的误操作
                        this.enter.Enabled = false;
                        break;
                    default:
                        //大于3次判定为恶意输入，进入非主人模式，启动定时器，关闭输入框120秒
                        //密码不正确时显示提示信息
                        this.information.Text = "密码不正确!已启动防御模式，已彻底关闭输入系统，你可以离开了！";
                        this.information.Location = new Point(width / 2 - this.information.Width / 2, 30);
                        //将密码框清空
                        this.passwordBox.Text = "";
                      
                        //关闭输入框
                        this.passwordBox.Enabled = false;
                        //设置定时器
                        this.more_try_timer.Interval = 1000*120;
                        this.more_try_timer.Enabled = true;
                        //停用窗口默认按钮，防止在进入关闭输入框状态按下回车使times计数值增加的误操作
                        this.enter.Enabled = false;
                        break;                                                           
                }
            }
        }

   

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            Process[] process;//创建一个PROCESS类数组
            process = Process.GetProcesses();//获取当前任务管理器所有运行中程序
            foreach (Process proces in process)//遍历
            {
                if (proces.ProcessName == "taskmgr")
                {
                    proces.Kill();
                }
            }

          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //屏掉alt+f4
            if ((e.KeyCode == Keys.F4) && (e.Alt == true))
            {
                e.Handled = true;
            }
            //屏蔽徽标键


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //部分1：初始化（定时器，置顶）
            //窗口最大化
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            //启动定时器
            this.kill_timer.Enabled = true;
           

            //部分2：设置窗口布局
            //获取当前窗口大小
            int height = this.Height;
            int width = this.Width;
            //提示信息位置
            this.tip.Location = new Point(width / 2 - 74, height / 2 - 40);
            //密码框位置：当前窗口大小-0.5*密码框长度
            this.passwordBox.Location = new Point(width / 2 - 60, height / 2 - 11);
            //确定按钮位置
            this.enter.Location = new Point(width / 2 - 40, height / 2 + 30);
            //将密码框清空
            this.passwordBox.Text = "";
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要退出程序吗？", "确认退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.icon.Visible = false;
                this.Close();
                this.Dispose();
                Application.Exit();
            }
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void more_try_timer_Tick(object sender, EventArgs e)
        {
            //等待时间到后重新开启输入框并清除提示信息
            this.passwordBox.Enabled = true;
            this.information.Text = "";
            this.more_try_timer.Enabled = false;
            //再次恢复窗口默认按钮  
            this.enter.Enabled = true;
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(times<3)
            {
                //当用户再次输入密码时自动清除提示信息
                this.information.Text = "";
            }
  
        }

   


    

       
    }
}
