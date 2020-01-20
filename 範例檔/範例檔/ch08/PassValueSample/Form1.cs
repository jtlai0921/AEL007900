using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PassValueSample
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
            a = 10;
            b = 15;
            label1.Text = " 1. 傳值呼叫前 :   a=" + a + "   b=" + b + "\n\n";
            PassValue(a, b);
            label1.Text += " 3. 傳值呼叫後 :   a=" + a + "   b=" + b;
        }

        private void PassValue(int x, int y)
        {
            x += 3;
            y += 2;
            label1.Text += " 2. 傳值呼叫中 :   x=" + x + "   y=" + y + "\n\n";
        }
    }
}