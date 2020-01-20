using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1, num2;
        private void Form1_Load(object sender, EventArgs e)
        {
            pic1.Enabled = false;
            pic2.Enabled = false;
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.Image = new Bitmap("Pokerbk.jpg");
            pic2.Image = new Bitmap("Pokerbk.jpg");
            lblMsg.Text = "按洗牌鈕遊戲開始..";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            pic1.Enabled = true;
            pic2.Enabled = true;
            btnOK.Enabled = false;
            pic1.Image = new Bitmap("Pokerbk.jpg");
            pic2.Image = new Bitmap("Pokerbk.jpg");
            Random r = new Random();
            num1 = r.Next(2, 15);  // 產生2~14 的正整數            
            num2 = r.Next(2, 15);
            lblMsg.Text = "請在撲克牌上按一下選取 ..";
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            pic1.Image = new Bitmap("Poker" + Convert.ToString(num1) + ".jpg");
            pic2.Image = new Bitmap("Poker" + Convert.ToString(num2) + ".jpg");
            if (num1 > num2)
                lblMsg.Text = " 你贏了 ! 按洗牌鈕 重玩 ....";
            else
                if (num1 == num2)
                    lblMsg.Text = " 平 手 !  按洗牌鈕 重玩 ....";
                else
                    lblMsg.Text = " 你輸了 !  按洗牌鈕 重玩 ....";
            pic1.Enabled = false;
            pic2.Enabled = false;
            btnOK.Enabled = true;
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            pic1.Image = new Bitmap("Poker" + Convert.ToString(num1) + ".jpg");
            pic2.Image = new Bitmap("Poker" + Convert.ToString(num2) + ".jpg");
            if (num2 > num1)
                lblMsg.Text = " 你贏了 ! 按洗牌鈕 重玩 ....";
            else
                if (num2 == num1)
                    lblMsg.Text = " 平 手 !  按洗牌鈕 重玩 ....";
                else
                    lblMsg.Text = " 你輸了 !  按洗牌鈕 重玩 ....";
            pic1.Enabled = false;
            pic2.Enabled = false;
            btnOK.Enabled = true;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
