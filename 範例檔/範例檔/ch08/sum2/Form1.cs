using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sum2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sum(int N, int M)
        {
            int total = 0;
            for (int i = N; i <= M; i++)
            {
                total += i;
            }
            label1.Text += Convert.ToString(N) + "加到" + Convert.ToString(M) + "的總和為 ：" + Convert.ToString(total) + "\n\n";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            sum(1, 10);
            sum(5, 12);
        }
    }
}
