using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MouseEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picCard.Image = Image.FromFile("card.jpg");  // 載入背面圖
            lblKing.Text = "";  //清空白
            //當觸動picCard的MouseLeave事件會執行Form1_Load事件處理函式
            picCard.MouseLeave += new EventHandler(Form1_Load);
        }

        private void picCard_MouseEnter(object sender, EventArgs e)
        {
            picCard.Image = Image.FromFile("king.jpg");  // 載入老K圖
        }

        private void picCard_MouseHover(object sender, EventArgs e)
        {
            lblKing.Text = "大家好！\n";
            lblKing.Text += "我是老Ｋ。Ｋ就是king，就是國王。\n";
            lblKing.Text += "很高興認識大家。";
        }
    }
}
