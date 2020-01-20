using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace maskedtextbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mtbChin.ResetOnSpace = false;
            mtbChin.BeepOnError = true;
            mtbChin.AsciiOnly = false;
            mtbChin.Mask = "&&&&";            
            mtbEng.Mask = ">LLLLLL";          
            mtbTel.Mask = "(00)-00000009";        
            mtbMobile.Mask = "(0000)000000";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string str1="";
            str1 += "中文姓名: " + mtbChin.Text + '\n';
            str1 += "英文姓名: " + mtbEng.Text + '\n';
            str1 += "電    話: " + mtbTel.Text + '\n';
            str1 += "手    機: " + mtbMobile.Text;
            MessageBox.Show(str1);
        }

        private void mtbChin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show(" 長度超過 或 不合法字元,限為中文字或英文字母 ! ");
        }

        private void mtbEng_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("長度超過 或 不合法字元, 限英文字母 ! ");
        }

        private void mtbTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("長度超過 或 不合法字元, 限數字 ! ");
        }

        private void mtbMobile_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("長度超過 或 不合法字元, 限數字 ! ");
        }
    }
}
