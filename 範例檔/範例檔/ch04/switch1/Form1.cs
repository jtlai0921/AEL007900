using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace switch1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int operand1, operand2;
            try
            {         
                operand1 = Convert.ToInt32(txtOperand1.Text);
                operand2 = Convert.ToInt32(txtOperand2.Text);
            }
            catch
            {
                lblMsg.Text = "輸入錯誤!  請輸入數值";
                return;
            }
            switch (txtOperator.Text)
            {
                case "+":
                    lblResult.Text = Convert.ToString(operand1 + operand2);
                    break;
                case "-":
                    lblResult.Text = Convert.ToString(operand1 - operand2);
                    break;
                case "*":
                    lblResult.Text = Convert.ToString(operand1 * operand2);
                    break;
                case "/":
                    lblResult.Text = Convert.ToString(operand1 / operand2);
                    break;
                default:
                    lblMsg.Text = "輸入錯誤!  限 +,-, *, / 四則運算子..";
                    break;
            }
        }
    }
}
