using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _99product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i, k;
            string show = ""; ;
            show = "\t\t九九乘法表\n\n";
            for (i = 1; i <= 9; i++)
            {
                for (k = 1; k <= i; k++)
                    show += i + "x" + k + "=" + i * k + "  ";
                show += '\n';    // 換行
            }
            MessageBox.Show(show);
        }
    }
}
