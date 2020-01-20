using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace textChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtQtyL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sumL, sumS, total;
                //計算全票總金額
                sumL=Convert.ToInt32(lblPriceL.Text) * Convert.ToInt32(txtQtyL.Text);
                //計算半票總金額
                sumS = Convert.ToInt32(lblPriceS.Text) * Convert.ToInt32(txtQtyS.Text);
                total = sumL + sumS;   //計算全票與半票合計
                lblSumL.Text = Convert .ToString (sumL );   //顯示全票總金額
                lblSumS.Text = Convert .ToString (sumS);   //顯示半票總金額
                lblTotal.Text = Convert.ToString(total);         //顯示全票與半票合計
            }
            catch
            {
                lblSumL.Text = "0";
                lblSumS.Text = "0";
                lblTotal.Text = "0";
            }
        }



        private void txtQtyL_Enter(object sender, EventArgs e)
        {
            txtQtyL.Text = "";
        }

        private void txtQtyS_Enter(object sender, EventArgs e)
        {
            txtQtyS.Text = "";
        }


    }
}
