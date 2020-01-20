using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace runner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int no;
        DateTime timeNow;
        private void Form1_Load(object sender, EventArgs e)
        {
            picRunner.SizeMode = PictureBoxSizeMode.StretchImage;
            picRunner.Image = imgIcon.Images[0];
            timer1.Interval = 100;
            no = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timeNow = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (no % 4)
            {
                case 0:
                    picRunner.Image = imgIcon.Images[0];
                    no++;
                    break;
                case 1:
                    picRunner.Image = imgIcon.Images[1];
                    no++;
                    break;
                case 2:
                    picRunner.Image = imgIcon.Images[2];
                    no++;
                    break;
                case 3:
                    picRunner.Image = imgIcon.Images[3];
                    no = 0;
                    break;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblMsg.Text = "總共花費" + (DateTime.Now - timeNow).TotalSeconds.ToString() + "秒";
        }
    }
}
