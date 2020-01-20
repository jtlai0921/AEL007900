using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findMax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //num1及num2可供給所有事件處理函式使用
        int num1, num2; 
        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            num1 = r.Next(1, 10);    // 產生 1~9 亂數
            num2 = r.Next(1, 10);    // 產生 1~9 亂數
            lblShow.Font = new Font("標楷體", 14, FontStyle.Regular);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text = Convert.ToString(num1);
            btn2.Text = Convert.ToString(num2);
            if (num1 > num2)
                lblShow.Text = "你贏了!";
            else if (num1 < num2)
                lblShow.Text = "你輸了!";
            else
                lblShow.Text = " 平手!";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn1.Text = Convert.ToString(num1);
            btn2.Text = Convert.ToString(num2);
            if (num2 > num1)
                lblShow.Text = "你贏了!";
            else if (num2 < num1)
                lblShow.Text = "你輸了!";
            else
                lblShow.Text = " 平手!";
        }
    }
}
