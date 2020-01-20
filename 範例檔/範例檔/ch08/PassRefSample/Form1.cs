using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PassRefSample
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
            label1.Text = " 1. 參考呼叫前 :   a=" + a + "   b=" + b + "\n\n";
            PassRef(ref a, ref b);
            label1.Text += " 3. 參考呼叫後 :   a=" + a + "   b=" + b;
        }

        private void PassRef(ref int x,ref int y)
        {
            x += 3;
            y += 2;
            label1.Text += " 2. 參考呼叫中 :   x=" + x + "   y=" + y + "\n\n";
        }
    }
}
