using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MouseDrag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool drag = false;  //宣告drag 變數,用來記錄是否可拖曳
       
        private void picBlack_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = true;
            }
        }

        private void picBlack_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                picBlack.Left += e.X;  // 目前將滑鼠座標當圖片方塊左上角座標
                picBlack.Top += e.Y;
            }
        }

        private void picBlack_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;  //不允許拖曳
        }
    }
}
