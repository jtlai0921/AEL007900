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
            this.Text = "表單Load事件測試...";
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Text = "表單Activateed事件測試...";
            this.BackColor = Color.Orange;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Text = "表單 Click 事件測試 ...";
            this.BackColor = Color.Green;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Text = "表單 DoubleClick 事件測試 ...";
            this.BackColor = Color.Gray;
        }
    }
}
