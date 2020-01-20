using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fontStyle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox1.SelectedIndex == 0)
            {
                label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Bold);
            }
            else if (checkedListBox1.SelectedIndex == 1)
            {
                label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Italic);
            }
            else if (checkedListBox1.SelectedIndex == 2)
            {
                label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Underline);
            }
            else if (checkedListBox1.SelectedIndex == 3)
            {
                label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Strikeout);
            }
        }


    }
}
