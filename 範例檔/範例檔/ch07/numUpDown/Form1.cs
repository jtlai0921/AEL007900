using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace numUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string size;
        string[] flower = new string[] { "", "鬱金香", "牡丹花", "百合花", "炮仗花" };

        private void Form1_Load(object sender, EventArgs e)
        {
            nudImage.Minimum = 1;
            nudImage.Maximum = 4;
            nudImage.Value = 1;
            picImage.Size = new Size(200, 200);
            hsbWidth.Minimum = 0;                   // 設定水平捲軸最小值為1
            hsbWidth.Maximum = picImage.Width;   // 設定水平捲軸最大值為200
            hsbWidth.Value = 200;                  // 設定水平捲軸目前的值為200
            vsbHeight.Minimum = 0;                 // 設定垂直捲軸最小值為1
            vsbHeight.Maximum = picImage.Height;  // 設定垂直捲軸最大值為200
            vsbHeight.Value = 200;                 // 設定垂直捲軸目前的值為200
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;  // 圖片隨控制項大小改變     
        }

        private void hsbWidth_Scroll(object sender, ScrollEventArgs e)
        {
            picImage.Width = hsbWidth.Value;  // 將水平捲軸的值指定給圖片方塊的寬 
            size = "圖片大小 ( " + hsbWidth.Value.ToString() + "," + vsbHeight.Value.ToString() + ")";
            lblMsg.Text = flower[(int)nudImage.Value] + size;
        }

        private void vsbHeight_Scroll(object sender, ScrollEventArgs e)
        {
            picImage.Height = vsbHeight.Value;  // 將垂直捲軸的值指定給圖片方塊的高           
            size = "圖片大小 ( " + hsbWidth.Value.ToString() + "," + vsbHeight.Value.ToString() + ")";
            lblMsg.Text = flower[(int)nudImage.Value] + size;
        }

        private void nudImage_ValueChanged(object sender, EventArgs e)
        {
            picImage.Image = Image.FromFile("flower" + ((int)(nudImage.Value)).ToString() + ".jpg");
            lblMsg.Text = flower[(int)nudImage.Value] + size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
