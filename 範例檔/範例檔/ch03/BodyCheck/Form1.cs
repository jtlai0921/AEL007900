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
            txtTall.MaxLength = 3;  //txtTall文字方塊只能輸入3位數
            txtWeight.ReadOnly = true;   //txtWeight文字方塊設為唯讀
           txtTall.TabIndex = 0;
        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            int tall = Convert.ToInt32(txtTall.Text);   //將txtTall文字方塊內容轉成int型別資料
            txtWeight.Text = "標準體重 = " + Convert.ToString((tall - 80) * 0.7) + " 公斤";
            txtTall.Focus();   //txtTall取得駐停焦點
        }

        private void btnWoman_Click(object sender, EventArgs e)
        {
            int tall = Convert.ToInt32(txtTall.Text);
            txtWeight.Text = "標準體重 = " + Convert.ToString((tall - 70) * 0.6) + " 公斤";
            txtTall.Focus();   //txtTall取得駐停焦點
        }
    }
}
