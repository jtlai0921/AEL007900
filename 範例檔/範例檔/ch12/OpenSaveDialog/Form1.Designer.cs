﻿namespace OpenSaveDialog
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.存檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.複製ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼上ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.項目符號ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定項目符號ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消項目符號ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.前景色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.編輯ToolStripMenuItem,
            this.項目符號ToolStripMenuItem,
            this.字型ToolStripMenuItem,
            this.顏色ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開檔ToolStripMenuItem,
            this.存檔ToolStripMenuItem,
            this.清除ToolStripMenuItem,
            this.結束ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 開檔ToolStripMenuItem
            // 
            this.開檔ToolStripMenuItem.Name = "開檔ToolStripMenuItem";
            this.開檔ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.開檔ToolStripMenuItem.Text = "開檔";
            this.開檔ToolStripMenuItem.Click += new System.EventHandler(this.開檔ToolStripMenuItem_Click);
            // 
            // 存檔ToolStripMenuItem
            // 
            this.存檔ToolStripMenuItem.Name = "存檔ToolStripMenuItem";
            this.存檔ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.存檔ToolStripMenuItem.Text = "存檔";
            this.存檔ToolStripMenuItem.Click += new System.EventHandler(this.存檔ToolStripMenuItem_Click);
            // 
            // 清除ToolStripMenuItem
            // 
            this.清除ToolStripMenuItem.Name = "清除ToolStripMenuItem";
            this.清除ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.清除ToolStripMenuItem.Text = "清除";
            this.清除ToolStripMenuItem.Click += new System.EventHandler(this.清除ToolStripMenuItem_Click);
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.結束ToolStripMenuItem.Text = "結束";
            this.結束ToolStripMenuItem.Click += new System.EventHandler(this.結束ToolStripMenuItem_Click);
            // 
            // 編輯ToolStripMenuItem
            // 
            this.編輯ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.複製ToolStripMenuItem,
            this.貼上ToolStripMenuItem,
            this.剪下ToolStripMenuItem});
            this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.編輯ToolStripMenuItem.Text = "編輯";
            // 
            // 複製ToolStripMenuItem
            // 
            this.複製ToolStripMenuItem.Name = "複製ToolStripMenuItem";
            this.複製ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.複製ToolStripMenuItem.Text = "複製";
            this.複製ToolStripMenuItem.Click += new System.EventHandler(this.複製ToolStripMenuItem_Click);
            // 
            // 貼上ToolStripMenuItem
            // 
            this.貼上ToolStripMenuItem.Name = "貼上ToolStripMenuItem";
            this.貼上ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.貼上ToolStripMenuItem.Text = "貼上";
            this.貼上ToolStripMenuItem.Click += new System.EventHandler(this.貼上ToolStripMenuItem_Click);
            // 
            // 剪下ToolStripMenuItem
            // 
            this.剪下ToolStripMenuItem.Name = "剪下ToolStripMenuItem";
            this.剪下ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.剪下ToolStripMenuItem.Text = "剪下";
            this.剪下ToolStripMenuItem.Click += new System.EventHandler(this.剪下ToolStripMenuItem_Click);
            // 
            // 項目符號ToolStripMenuItem
            // 
            this.項目符號ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定項目符號ToolStripMenuItem,
            this.取消項目符號ToolStripMenuItem});
            this.項目符號ToolStripMenuItem.Name = "項目符號ToolStripMenuItem";
            this.項目符號ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.項目符號ToolStripMenuItem.Text = "項目符號";
            // 
            // 設定項目符號ToolStripMenuItem
            // 
            this.設定項目符號ToolStripMenuItem.Name = "設定項目符號ToolStripMenuItem";
            this.設定項目符號ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.設定項目符號ToolStripMenuItem.Text = "設定項目符號";
            this.設定項目符號ToolStripMenuItem.Click += new System.EventHandler(this.設定項目符號ToolStripMenuItem_Click);
            // 
            // 取消項目符號ToolStripMenuItem
            // 
            this.取消項目符號ToolStripMenuItem.Name = "取消項目符號ToolStripMenuItem";
            this.取消項目符號ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.取消項目符號ToolStripMenuItem.Text = "取消項目符號";
            this.取消項目符號ToolStripMenuItem.Click += new System.EventHandler(this.取消項目符號ToolStripMenuItem_Click);
            // 
            // 字型ToolStripMenuItem
            // 
            this.字型ToolStripMenuItem.Name = "字型ToolStripMenuItem";
            this.字型ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.字型ToolStripMenuItem.Text = "字型";
            this.字型ToolStripMenuItem.Click += new System.EventHandler(this.字型ToolStripMenuItem_Click);
            // 
            // 顏色ToolStripMenuItem
            // 
            this.顏色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.前景色ToolStripMenuItem,
            this.背景色ToolStripMenuItem});
            this.顏色ToolStripMenuItem.Name = "顏色ToolStripMenuItem";
            this.顏色ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.顏色ToolStripMenuItem.Text = "顏色";
            // 
            // 前景色ToolStripMenuItem
            // 
            this.前景色ToolStripMenuItem.Name = "前景色ToolStripMenuItem";
            this.前景色ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.前景色ToolStripMenuItem.Text = "前景色";
            this.前景色ToolStripMenuItem.Click += new System.EventHandler(this.前景色ToolStripMenuItem_Click);
            // 
            // 背景色ToolStripMenuItem
            // 
            this.背景色ToolStripMenuItem.Name = "背景色ToolStripMenuItem";
            this.背景色ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.背景色ToolStripMenuItem.Text = "背景色";
            this.背景色ToolStripMenuItem.Click += new System.EventHandler(this.背景色ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 201);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "記事本";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 存檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 複製ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼上ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪下ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 項目符號ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定項目符號ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消項目符號ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顏色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 前景色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除ToolStripMenuItem;
    }
}

