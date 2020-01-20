using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] company = new string[3];

            company[0] = "台北";
            company[1] = "台中";
            company[2] = "高雄";
            int[,] amt = new int[,] { { 1000, 2000, 3000, 4000 }, { 1500, 2500, 3500, 4500 }, 
          {3200, 1800, 3600, 1400 } };
            int[] sum = new int[4];
            // 計算各營業處四季業績合計置入 sum[i]
            for (int i = 0; i <= company.GetUpperBound(0); i++)
            {
                for (int k = 0; k <= amt.GetUpperBound(1); k++)
                {
                    sum[i] += amt[i, k];
                }
            }
            //  標題顯示在標籤控制項
            label1.Text = "營業處  第1季  第2季  第3季  第4季   合計 \n\n";
            // 逐列顯示各營業處的名稱、第1季、第2季、第3季、第4季、合計的營業額
            for (int i = 0; i <= company.GetUpperBound(0); i++)
            {
                label1.Text += company[i] + "      ";
                for (int k = 0; k <= amt.GetUpperBound(1); k++)
                {
                    label1.Text += amt[i, k].ToString() + "    ";
                }
                label1.Text += Convert.ToString(sum[i]) + "\n";
            }
        }
    }
}
