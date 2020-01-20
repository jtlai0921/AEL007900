using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       
       
        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            int price11 = 0, price12 = 0, price13 = 0, price21 = 0, price22 = 0, price23 = 0;

            if (rdb1.Checked)
                price11 = 100;
            else if (rdb2.Checked)
                price12=90;
            else
                price13=110;

            if (chk1.Checked)
                price21=20;

            if (chk2.Checked )
                price22=30;

            if (chk3.Checked )
                price23=40;
            lblSum.Text = "消費金額 : " + Convert.ToString(price11 + price12 + price13 + price21 + price22 + price23);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       
    }
}
