using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenSaveDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // RichTextBox1填滿整個表單
            richTextBox1.Dock = DockStyle.Fill;
        }

        private void 開檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 讀檔
                richTextBox1.LoadFile(openFileDialog1.FileName , RichTextBoxStreamType.RichText);
            }
        }

        private void 存檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 存檔
                richTextBox1.SaveFile (saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void 清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();  // 將選取的範圍複製到剪貼簿
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();  // 將剪貼簿的內容貼到目前的插入點
        }

        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();    // 將選取的範圍剪下到剪貼簿
        }

        private void 設定項目符號ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = true;   // 選取範圍設定項目符號
        }

        private void 取消項目符號ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = false;  // 選取範圍取消項目符號
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void 前景色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void 背景色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = colorDialog1.Color;
            }
        }
    }
}
