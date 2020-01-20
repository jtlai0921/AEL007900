using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FontColorDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "海角七號";
            fontDialog1.ShowColor = true;   // 顯示顏色設定清單;
        }

        private void btnSetFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)  //檢查是否按<確定>鈕
            {
                lblMsg.Font = fontDialog1.Font;  //將字型設定顯示在lblMsg上面
                lblMsg.ForeColor = fontDialog1.Color; //將設定顏色當lblMsg的前景色
            }
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() ==DialogResult.OK )  //檢查是否按<確定>鈕
            {
                lblMsg.BackColor = colorDialog1.Color;         // 將設定顏色當lblMsg的背景色
            }
        }
    }
}
