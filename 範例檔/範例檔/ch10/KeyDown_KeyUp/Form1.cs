using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 鍵盤事件測試
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picRider.Image = Image.FromFile("bike_go.jpg");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            lblKey.Text = "按下" + Convert.ToString(e.KeyCode) + "鍵, 鍵值為" + Convert.ToString(e.KeyValue);
            if (e.KeyCode == Keys.Right)
            {
                picRider.Image = Image.FromFile("bike_go.jpg");
                if (picRider.Left >= this.Width)
                {
                    picRider.Left = 0 - picRider.Width;
                }
                else
                {
                    picRider.Left += 20;
                }
                lblState.Text = "前進!!";
            }
            else if (e.KeyCode == Keys.Left)
            {
                picRider.Image = Image.FromFile("bike_go.jpg");
                if (picRider.Width + picRider.Left <= 0)
                {
                    picRider.Left = this.Width;
                }
                else
                {
                    picRider.Left -= 20;
                }
                lblState.Text = "後退!!";
            }
            else if (e.KeyCode == Keys.Up)
            {
                picRider.Image = Image.FromFile("bike_up.jpg");
                lblState.Text = "舉孤輪!!";
            }
            else if (e.KeyCode == Keys.Down)
            {
                picRider.Image = Image.FromFile("bike_stop.jpg");
                lblState.Text = "煞車!!";
            }
        }
    }
}
