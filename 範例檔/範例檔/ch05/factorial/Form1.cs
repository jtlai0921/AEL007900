using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            long fact = 1, keyin;
            keyin = int.Parse(txtInput.Text);  //keyin = Convert.ToInt32(txtInput.Text)
            if (keyin <= 0)
            {
                MessageBox.Show("輸入值必須是正整數");
                txtInput.Text = "";
            }
            else
            {
                while (keyin >= 1)
                {
                    fact *= keyin;
                    keyin--;
                }
                lblMsg.Text = txtInput.Text + "! = " + Convert.ToString(fact);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
