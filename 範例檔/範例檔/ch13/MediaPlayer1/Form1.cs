﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaPlayer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;  // 填滿整個表單
        }

        //開啟開檔對話方塊，並判斷是否按下[開啟]鈕
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // 表單標題顯示多媒體檔案路徑
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Text = openFileDialog1.FileName;
                // AxWindowsMediaPlayer1 播放開啟對話方塊所選擇的多媒體檔
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();//播放多媒體檔
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause(); // 暫停播放多媒體檔
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();  //  停止播放多媒體檔
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous(); //   播放上一段
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();  //   播放下一段
        }
    }
}
