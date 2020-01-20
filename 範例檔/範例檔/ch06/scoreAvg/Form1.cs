using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace scoreAvg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n = 0;     //目前第n位學生的成績
        int[] score = new int[5];  //宣告score[0]~score[4]陣列元素來存放五位學生的成績

        private void Form1_Load(object sender, EventArgs e)
        {
            lblN.Text = "第" + Convert.ToString(n + 1) + "位同學成績：";
            btnAvg.Enabled = false;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = "";
                score[n] = Convert.ToInt32(txtScore.Text);
                for (int i = 0; i <= n; i++)
                {
                    lblMsg.Text += "第" + Convert.ToString(i + 1) + "位同學成績：" + Convert.ToString(score[i]) + "\n";
                }
                n++;
                txtScore.Text = "";
                txtScore.Focus();
            }
            catch
            {
                MessageBox.Show("請輸入數值");//catch區塊處理例外程式
            } 
            if (n == 5)
            {
                lblMsg.Text += "輸入完畢";
                btnInput.Enabled = false;
                btnAvg.Enabled = true;
            }
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            int sum = 0, avg;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            //score.Length會取陣列元素的個數5，所以avg = sum/5;
            avg = sum / score.Length;
            MessageBox.Show("平均成績：" + Convert.ToString(avg));
        }
    }
}
