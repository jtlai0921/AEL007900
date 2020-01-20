using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int getpoint;
            string f_name;
            Random rnd = new Random();
            getpoint = rnd.Next(1, 7);
            f_name = Convert.ToString(getpoint) + ".jpg";
            pic1.Image = Image.FromFile(f_name);
            lblMsg.Text = "你得到 " + Convert.ToString(getpoint) + " 點 !!";
        }
    }
}
