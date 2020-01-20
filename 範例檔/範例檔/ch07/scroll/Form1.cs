using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace scroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string flowerName , size ;
        private void Form1_Load(object sender, EventArgs e)
        {
            picImage.Size = new Size(200, 200);    // 設定圖片大小
            hsbWidth.Minimum = 0;                  // 設定水平捲軸最小值為0
            hsbWidth.Maximum = picImage.Width;     // 設定水平捲軸最大值為圖片最大寬度
          
            vsbHeight.Minimum = 0;                 // 設定垂直捲軸最小值為0
            vsbHeight.Maximum = picImage.Height;   // 設定垂直捲軸最大值為為圖片最大高度

            hsbWidth.Value = hsbWidth.Maximum;      // 設定水平捲軸停在最大值200處
            vsbHeight.Value = vsbHeight.Maximum;     // 設定垂直捲軸停在最大值200處
            
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;           
        }

        private void hsbWidth_Scroll(object sender, ScrollEventArgs e)
        {
             picImage.Width = hsbWidth.Value;  // 將水平捲軸的值指定給圖片方塊的寬 
             size = "圖片大小 ( " + hsbWidth.Value.ToString() + "," + vsbHeight.Value.ToString() + ")";
             lblMsg.Text = flowerName + size;
        }

        private void vsbHeight_Scroll(object sender, ScrollEventArgs e)
        {
            picImage.Height = vsbHeight.Value;  // 將垂直捲軸的值指定給圖片方塊的高           
            size = "圖片大小 ( " + hsbWidth.Value.ToString() + "," + vsbHeight.Value.ToString() + ")";
            lblMsg.Text = flowerName + size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowerName = "鬱金香";
            picImage.Image = Image.FromFile("flower1.jpg");
            lblMsg.Text = flowerName + size;
        }

        private void btnFlower2_Click(object sender, EventArgs e)
        {
            flowerName = "牡丹花";
            picImage.Image = Image.FromFile("flower2.jpg");
            lblMsg.Text = flowerName + size;
        }

        private void btnFlower3_Click(object sender, EventArgs e)
        {
            flowerName = "百合花";
            picImage.Image = Image.FromFile("flower3.jpg");
            lblMsg.Text = flowerName + size;
        }

        private void btnFlower4_Click(object sender, EventArgs e)
        {
            flowerName = "炮仗花";
            picImage.Image = Image.FromFile("flower4.jpg");
            lblMsg.Text = flowerName + size;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }   
    }
}
