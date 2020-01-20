using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Overloads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a, b;
            a = 21; b = 14;
            double[] ary = new double[] { 12.1, 54.3, 7.2, 40 };
            label1.Text = Convert.ToString(a) + "和" + Convert.ToString(b) + "最小的數值為 : " + Convert.ToString(GetMin(a, b));
            label1.Text += "\n\n";
            label1.Text += "陣列元素(12.1, 54.3, 7.2, 40)中最小的數值為 : " + Convert.ToString(GetMin(ref ary));
        }
        //取兩個整數之最小數
        private int GetMin(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
        //取兩個浮點數之最小數
        private double GetMin(ref double[] vArray)
        {
            double min = vArray[0];
            for (int i = 1; i <= vArray.GetUpperBound(0); i++)
            {
                if (vArray[i] < min)
                {
                    min = vArray[i];
                }
            }
            return min;
        }
    }
}
