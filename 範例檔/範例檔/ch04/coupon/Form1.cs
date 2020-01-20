using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace coupon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //按 [對答] 鈕會執行btnOK_Click事件處理函式
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdb2.Checked)
                lblResult.Text = "答對了!";
            else
                lblResult.Text = "答錯了!";
        }
    }
}
