using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int sum(int N, int M)
        {
            int total = 0;
            for (int i = N; i <= M; i++)
            {
                total += i;
            }
            return total;     // 傳回total，並返回原呼叫處
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int tot = 0;
            tot = sum(1, 10);// 呼叫sum方法，進行1累加到10
            label1.Text = "1加到10的總和為 ：" + Convert.ToString(tot) + "\n\n";
            //呼叫sum方法，進行5累加到12
            label1.Text += "5加到12的總和為 ：" + Convert.ToString(sum(5, 12)) + "\n";  
        }
    }
}
