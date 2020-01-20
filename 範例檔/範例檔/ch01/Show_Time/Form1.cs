using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Show_Time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString ();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "電子鐘面板";
        }
    }
}
