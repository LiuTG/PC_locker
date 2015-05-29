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
        
        [DllImport("user32.dll")]

        private static extern IntPtr GetForegroundWindow();
        public Form1()
        {
            InitializeComponent();
        
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //窗口最大化
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;

            //启动定时器
            this.timer1.Enabled = true;

            //获取当前窗口大小
            int height = this.Height;
            int width = this.Width;
            //提示信息位置
            this.tip.Location = new Point(width/2 - 74, height/2 - 40);
            //密码框位置：当前窗口大小-0.5*密码框长度
            this.password.Location = new Point(width/2 - 60,height/2 - 11);
            //确定按钮位置
            this.enter.Location = new Point(width/2 - 40, height/2 + 30);
            
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if("q87623460" == this.password.Text)
            {
                //窗口最小化
                this.WindowState = FormWindowState.Minimized;
                //隐藏任务栏区图标 
                this.ShowInTaskbar = false;
                //托盘显示
                
                //关闭定时器
                this.timer1.Enabled = false;

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
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

   


    

       
    }
}
