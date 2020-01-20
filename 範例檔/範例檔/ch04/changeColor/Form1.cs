using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace changeColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblShow.BackColor = Color.Aqua;
            lblShow.Text = "";
            lblShow.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lblShow.BackColor == Color.Aqua)
            {
                lblShow.BackColor = Color.Yellow;
                lblShow.Text = "目前背景色為黃色";
            }
            else
            {
                lblShow.BackColor = Color.Aqua;
                lblShow.Text = "目前背景色為淺藍色";
            }
        }
    }
}
