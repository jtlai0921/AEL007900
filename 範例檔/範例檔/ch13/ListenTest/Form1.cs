using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;    //引用Microsoft.VisualBasic命名空間
using Microsoft.VisualBasic.Devices;    //引用Microsoft.VisualBasic.Devices命名空間


namespace ListTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string pathName;  //檔案路徑與檔名
        int testNum;           //存放亂數出來的數值

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            btnReplay.Enabled = false;
            btnCheck.Enabled = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            lblMsg.Text = "";
            Random rnd = new Random();  //產生亂數物件rnd
            testNum = rnd.Next(1, 11); //產生1~10的亂數
            pathName = Convert.ToString(testNum) + ".wav";  //合併成數字聲音檔
            Computer myComputer = new Computer();
            //播放數字聲音檔
            myComputer.Audio.Play(pathName, AudioPlayMode.WaitToComplete);  
            btnPlay.Enabled = false;    // 播放按鈕無效
            btnReplay.Enabled = true;   // 重聽按鈕有效
            btnCheck.Enabled = true;    //對答按鈕有效
            txtInput.Focus();           // 將游標移到輸入文字方塊
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            myComputer.Audio.Play(pathName, AudioPlayMode.WaitToComplete);
            txtInput.Focus();           // 將游標移到輸入文字方塊
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string[] ary = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            btnPlay.Enabled = true;      // 播放按鈕有效
            btnReplay.Enabled = false;   // 重聽按鈕無效
            if ((txtInput.Text).ToLower() == ary[testNum - 1])  // 對答案
            {
                lblMsg.Text = "答對了 !";    
            }
            else
            {
                lblMsg.Text = "答錯了 !";
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}