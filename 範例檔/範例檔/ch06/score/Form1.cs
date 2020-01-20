using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace score
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] sname = new string[] { "趙一", "林二", "張三", "李四", "王五", "孫六" };
        int[] score = new int[] { 75, 95, 55, 66, 85, 90 };

        private void btnScore_Click(object sender, EventArgs e)
        {
            label1.Text = "   姓名    成績\n";    // 抬頭訊息
            // 取得 序號、姓名、成績合併成一列顯示到lblShow標籤控制項上
            for (int i = 0; i <= sname.GetUpperBound(0); i++)
            {
                label1.Text += (i + 1).ToString() + ". " + sname[i] + "     " +
                            Convert.ToString(score[i]) + "\n";
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string[] sname1 = new string[6];
            int[] score1 = new int[6];
            sname.CopyTo(sname1, 0);
            score.CopyTo(score1, 0);
            // 抬頭訊息
            label1.Text = "   姓名    成績     名次\n";
            Array.Sort(score1, sname1);    // 遞增排序
            Array.Reverse(score1);        // 遞減排序
            Array.Reverse(sname1);       // 遞減排序
            //取得 序號、姓名、成績、名次合併成一列顯示到標籤控制項上
            for (int i = 0; i <= sname1.GetUpperBound(0); i++)
            {
                label1.Text += (i + 1).ToString() + ". " + sname1[i] + "    " +
                     Convert.ToString(score1[i]) + "           " + (i + 1).ToString() + "\n";
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            int count = 0;    // 存放及格人數
            label1.Text = "    姓名    成績\n";  // 顯示抬頭訊息
            //取得 序號、姓名、及格成績合併成一列顯示到標籤控制項上
            for (int i = 0; i <= sname.GetUpperBound(0); i++)
            {
                if (score[i] >= 60 && score[i] <= 100)
                {
                    count++;
                    label1.Text += count.ToString() + ". " + sname[i] + "    " +
                          Convert.ToString(score[i]) + "\n";
                
                }
            }
            label1.Text += "\n及格人數共:" + Convert.ToString(count) + "人";
        }
    }
}
