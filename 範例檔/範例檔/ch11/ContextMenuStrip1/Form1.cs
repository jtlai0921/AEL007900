using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContextMenuStrip1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Visual Basic";
            label1.ForeColor = Color.Red;        //設前景色為紅色
            label1.Font = new Font("細明體", 20, FontStyle.Bold);
            label1.ContextMenuStrip  = contextMenuStrip1;
            細明體ToolStripMenuItem1.Click += new EventHandler(細明體ToolStripMenuItem_Click);
            新細明體ToolStripMenuItem1.Click += new EventHandler(新細明體ToolStripMenuItem_Click);
            標楷體ToolStripMenuItem1.Click += new EventHandler(標楷體ToolStripMenuItem_Click);
            紅色ToolStripMenuItem1.Click += new EventHandler(紅色ToolStripMenuItem_Click);
            綠色ToolStripMenuItem1.Click += new EventHandler(綠色ToolStripMenuItem_Click);
            藍色ToolStripMenuItem1.Click += new EventHandler(藍色ToolStripMenuItem_Click);
        }

        private void 細明體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 設字型為細明體、大小為20、樣式為粗體
            label1.Font = new Font("細明體", 20, FontStyle.Bold);
        }

        private void 新細明體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 設字型為新細明體、大小為20、樣式為粗體
            label1.Font = new Font("新細明體", 20, FontStyle.Bold);
        }

        private void 標楷體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 設字型為標楷體、大小為20、樣式為粗體
            label1.Font = new Font("標楷體", 20, FontStyle.Bold);
        }

        private void 紅色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;   // 設前景色為紅色
        }

        private void 綠色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;   // 設前景色為綠色
        }

        private void 藍色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;  // 設前景色為藍色
        }
    }
}
