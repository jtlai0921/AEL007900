using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // 宣告arrPic為圖片控制項陣列，陣列元素arrPic[0]~arrPic[3]，但arrPic[0]省略不用
            PictureBox[] arrPic = new PictureBox[4];
            // 宣告getPoint陣列用來存放亂數值，陣列元素getpoint[0]~getpoint[3]，但getpoint[0]省略不用
            int[] getpoint = new int[4];
            string f_name = "";          // f_name字串變數用來存放圖片檔名
            int total = 0;        // total整數變數用來存放三個骰子的總點數

            arrPic[1] = pic1;          // 控制項陣列的第一個元素即為pic1圖片控制項
            arrPic[2] = pic2;
            arrPic[3] = pic3;

            Random rnd = new Random();
            for (int i = 1; i <= arrPic.GetUpperBound(0); i++)   // 控制產生亂數的次數
            {

                getpoint[i] = rnd.Next(1, 7);  // 產生1~6 間之亂數
                total += getpoint[i];            // 產生的點數累加到total變數
                // 取得對應的骰子的點數圖檔名    
                f_name = Convert.ToString(getpoint[i]) + ".jpg";    
                // 將指定圖檔置入控制項陣列在表單對應的圖片控制項      
                arrPic[i].Image = Image.FromFile(f_name);
            }
            lblMsg.Text = "共得到 " + Convert.ToString(total) + " 點 !!";
        }
    }
}
