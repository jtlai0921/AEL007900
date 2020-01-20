using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KTV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int flag = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 30;          // 計時器週期設為0.03秒
            timer1.Enabled = false;        // 關閉計時器
            pic2.Location = pic1.Location; // 將pic2置於pic1同位置,兩者重疊
            pic1.Width = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag == 1)                            // 若flag為1,表播放第1段歌詞       
            {
                pic1.Image = new Bitmap("fish1.bmp"); // 第1段藍色歌詞顯示在pic1圖片方塊
                pic2.Image = new Bitmap("fish2.bmp"); // 第1段紅色歌詞顯示在pic2圖片方塊
            }
            else if (flag == -1)    // 若flag為-1,表播放第2段歌詞
            {
                pic1.Image = Image.FromFile("fish3.bmp");  // 第2段藍色歌詞顯示在pic1圖片方塊
                pic2.Image = Image.FromFile("fish4.bmp");  // 2段紅色歌詞顯示在pic1圖片方塊
            }
            if (pic1.Width < (pic2.Width))    // 檢查pic1寬度是否小於pic2的寬度
                pic1.Width = pic1.Width + 2;   // 若是, 則將pic1的寬度加2 pixels
            else
            {
                pic2.Location = pic1.Location;  // 若pic1寬度pic2寬度表該段播完
                pic1.Width = 0;                // 將pic1寬度設為0及不顯示
                flag = -flag;       // 將flag變號改由另一段歌詞播放
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;      // 關閉計時器
        }
    }
}
