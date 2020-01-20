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
            lblMove.Text = "海角七號";
            lblMove.Font = new Font("標楷體", 12, FontStyle.Bold);
            lblMove.BackColor = Color.Cyan;
            lblMove.ForeColor = Color.Blue;
            lblMove.Location = new Point(100, 100);
            btnRight.Enabled = false;   // 右鈕失效
            btnLeft.Enabled = false;    // 左鈕失效
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int x, y;
            x = lblMove.Location.X;
            y = lblMove.Location.Y - 10;
            lblMove.Location = new Point(x, y);  // 移到新位置
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int x, y;
            x = lblMove.Location.X;
            y = lblMove.Location.Y + 10;
            lblMove.Location = new Point(x, y);  // 移到新位置
        }
    }
}
