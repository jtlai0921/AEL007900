using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PokerSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] pk = new int[5];
            //產生1-13之間的五個亂數並放pk陣列內
            GetRnd(ref pk, 1, 13, 5);   

            label1.Text = "排序前：";
            for (int i = 0; i <= pk.GetUpperBound(0); i++)
            {
                label1.Text += Convert.ToString(pk[i]) + ", ";
            }
            Array.Sort(pk);   //排序
            PictureBox[] defPic = new PictureBox[6];
            defPic[1] = pic1; defPic[2] = pic2; defPic[3] = pic3;
            defPic[4] = pic4; defPic[5] = pic5;
            label2.Text = "排序後：";
            for (int i = 0; i <= pk.GetUpperBound(0); i++)
            {
                label2.Text += Convert.ToString(pk[i]) + ", ";
                defPic[i + 1].Image = new Bitmap("Poker" + Convert.ToString(pk[i]) + ".jpg");
            }
        }

        // GetRnd函式可用來取得n~m之間的num個不重複的亂數，並傳給所設定的陣列
        private void GetRnd(ref int[] vArray, int min, int max, int num)
        {
            int max_dim, rem_num, choice;
            max_dim = max - min;
            int[] t = new int[max_dim + 1];
            for (int i = 0; i <= max_dim; i++)
            {
                t[i] = min + i;
            }
            rem_num = max_dim;
            Random rnd = new Random();
            for (int i = 0; i < num; i++)
            {
                choice = rnd.Next(rem_num);
                vArray[i] = t[choice];
                for (int j = choice; j < rem_num; j++)
                {
                    t[j] = t[j + 1];
                }
                rem_num -= 1;
            }
        }
    }
}
