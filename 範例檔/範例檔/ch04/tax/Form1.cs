using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                double income, tax, taxRate;
                income = Convert.ToDouble(txtIncome.Text);
                taxRate = (income < 100 ? 0.15 : (income < 300 ? 0.2 : 0.4));
                lblTaxRate.Text = Convert.ToString(taxRate * 100) + "%";
                tax = income * taxRate * 10000;
                lblTax.Text = Convert.ToString(tax) + "元";
            }
            catch
            {
                MessageBox.Show("請輸入數值...");
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
