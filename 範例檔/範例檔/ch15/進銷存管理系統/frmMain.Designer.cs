namespace 進銷存管理系統
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基本資料管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客戶資料管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客戶資料查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.供應商資料管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.供應商資料查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.庫存資料管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.庫存資料查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.進貨管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.進貨處理作業ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.進貨查詢作業ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.進退處理作業ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.進退查詢作業ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.銷貨管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.銷貨處理作業ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.銷貨查詢作業ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.銷退處理作業ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.銷退查詢作業ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本資料管理ToolStripMenuItem,
            this.進貨管理ToolStripMenuItem,
            this.銷貨管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基本資料管理ToolStripMenuItem
            // 
            this.基本資料管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客戶資料管理ToolStripMenuItem,
            this.客戶資料查詢ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.供應商資料管理ToolStripMenuItem,
            this.供應商資料查詢ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.庫存資料管理ToolStripMenuItem,
            this.庫存資料查詢ToolStripMenuItem});
            this.基本資料管理ToolStripMenuItem.Name = "基本資料管理ToolStripMenuItem";
            this.基本資料管理ToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.基本資料管理ToolStripMenuItem.Text = "基本資料管理";
            // 
            // 客戶資料管理ToolStripMenuItem
            // 
            this.客戶資料管理ToolStripMenuItem.Name = "客戶資料管理ToolStripMenuItem";
            this.客戶資料管理ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.客戶資料管理ToolStripMenuItem.Text = "客戶資料管理";
            this.客戶資料管理ToolStripMenuItem.Click += new System.EventHandler(this.客戶資料管理ToolStripMenuItem_Click);
            // 
            // 客戶資料查詢ToolStripMenuItem
            // 
            this.客戶資料查詢ToolStripMenuItem.Name = "客戶資料查詢ToolStripMenuItem";
            this.客戶資料查詢ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.客戶資料查詢ToolStripMenuItem.Text = "客戶資料查詢";
            this.客戶資料查詢ToolStripMenuItem.Click += new System.EventHandler(this.客戶資料查詢ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            // 
            // 供應商資料管理ToolStripMenuItem
            // 
            this.供應商資料管理ToolStripMenuItem.Name = "供應商資料管理ToolStripMenuItem";
            this.供應商資料管理ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.供應商資料管理ToolStripMenuItem.Text = "供應商資料管理";
            this.供應商資料管理ToolStripMenuItem.Click += new System.EventHandler(this.供應商資料管理ToolStripMenuItem_Click);
            // 
            // 供應商資料查詢ToolStripMenuItem
            // 
            this.供應商資料查詢ToolStripMenuItem.Name = "供應商資料查詢ToolStripMenuItem";
            this.供應商資料查詢ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.供應商資料查詢ToolStripMenuItem.Text = "供應商資料查詢";
            this.供應商資料查詢ToolStripMenuItem.Click += new System.EventHandler(this.供應商資料查詢ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(151, 6);
            // 
            // 庫存資料管理ToolStripMenuItem
            // 
            this.庫存資料管理ToolStripMenuItem.Name = "庫存資料管理ToolStripMenuItem";
            this.庫存資料管理ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.庫存資料管理ToolStripMenuItem.Text = "庫存資料管理";
            this.庫存資料管理ToolStripMenuItem.Click += new System.EventHandler(this.庫存資料管理ToolStripMenuItem_Click);
            // 
            // 庫存資料查詢ToolStripMenuItem
            // 
            this.庫存資料查詢ToolStripMenuItem.Name = "庫存資料查詢ToolStripMenuItem";
            this.庫存資料查詢ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.庫存資料查詢ToolStripMenuItem.Text = "庫存資料查詢";
            this.庫存資料查詢ToolStripMenuItem.Click += new System.EventHandler(this.庫存資料查詢ToolStripMenuItem_Click);
            // 
            // 進貨管理ToolStripMenuItem
            // 
            this.進貨管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.進貨處理作業ToolStripMenuItem,
            this.進貨查詢作業ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.進退處理作業ToolStripMenuItem,
            this.進退查詢作業ToolStripMenuItem});
            this.進貨管理ToolStripMenuItem.Name = "進貨管理ToolStripMenuItem";
            this.進貨管理ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.進貨管理ToolStripMenuItem.Text = "進貨管理";
            // 
            // 進貨處理作業ToolStripMenuItem
            // 
            this.進貨處理作業ToolStripMenuItem.Name = "進貨處理作業ToolStripMenuItem";
            this.進貨處理作業ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.進貨處理作業ToolStripMenuItem.Text = "進貨處理作業";
            this.進貨處理作業ToolStripMenuItem.Click += new System.EventHandler(this.進貨處理作業ToolStripMenuItem_Click);
            // 
            // 進貨查詢作業ToolStripMenuItem
            // 
            this.進貨查詢作業ToolStripMenuItem.Name = "進貨查詢作業ToolStripMenuItem";
            this.進貨查詢作業ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.進貨查詢作業ToolStripMenuItem.Text = "進貨查詢作業";
            this.進貨查詢作業ToolStripMenuItem.Click += new System.EventHandler(this.進貨查詢作業ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(139, 6);
            // 
            // 進退處理作業ToolStripMenuItem
            // 
            this.進退處理作業ToolStripMenuItem.Name = "進退處理作業ToolStripMenuItem";
            this.進退處理作業ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.進退處理作業ToolStripMenuItem.Text = "進退處理作業";
            this.進退處理作業ToolStripMenuItem.Click += new System.EventHandler(this.進退處理作業ToolStripMenuItem_Click);
            // 
            // 進退查詢作業ToolStripMenuItem
            // 
            this.進退查詢作業ToolStripMenuItem.Name = "進退查詢作業ToolStripMenuItem";
            this.進退查詢作業ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.進退查詢作業ToolStripMenuItem.Text = "進退查詢作業";
            this.進退查詢作業ToolStripMenuItem.Click += new System.EventHandler(this.進退查詢作業ToolStripMenuItem_Click);
            // 
            // 銷貨管理ToolStripMenuItem
            // 
            this.銷貨管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.銷貨處理作業ToolStripMenuItem,
            this.銷貨查詢作業ToolStripMenuItem,
            this.toolStripMenuItem4,
            this.銷退處理作業ToolStripMenuItem,
            this.銷退查詢作業ToolStripMenuItem});
            this.銷貨管理ToolStripMenuItem.Name = "銷貨管理ToolStripMenuItem";
            this.銷貨管理ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.銷貨管理ToolStripMenuItem.Text = "銷貨管理";
            // 
            // 銷貨處理作業ToolStripMenuItem
            // 
            this.銷貨處理作業ToolStripMenuItem.Name = "銷貨處理作業ToolStripMenuItem";
            this.銷貨處理作業ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.銷貨處理作業ToolStripMenuItem.Text = "銷貨處理作業";
            this.銷貨處理作業ToolStripMenuItem.Click += new System.EventHandler(this.銷貨處理作業ToolStripMenuItem_Click);
            // 
            // 銷貨查詢作業ToolStripMenuItem
            // 
            this.銷貨查詢作業ToolStripMenuItem.Name = "銷貨查詢作業ToolStripMenuItem";
            this.銷貨查詢作業ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.銷貨查詢作業ToolStripMenuItem.Text = "銷貨查詢作業";
            this.銷貨查詢作業ToolStripMenuItem.Click += new System.EventHandler(this.銷貨查詢作業ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(139, 6);
            // 
            // 銷退處理作業ToolStripMenuItem
            // 
            this.銷退處理作業ToolStripMenuItem.Name = "銷退處理作業ToolStripMenuItem";
            this.銷退處理作業ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.銷退處理作業ToolStripMenuItem.Text = "銷退處理作業";
            this.銷退處理作業ToolStripMenuItem.Click += new System.EventHandler(this.銷退處理作業ToolStripMenuItem_Click);
            // 
            // 銷退查詢作業ToolStripMenuItem
            // 
            this.銷退查詢作業ToolStripMenuItem.Name = "銷退查詢作業ToolStripMenuItem";
            this.銷退查詢作業ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.銷退查詢作業ToolStripMenuItem.Text = "銷退查詢作業";
            this.銷退查詢作業ToolStripMenuItem.Click += new System.EventHandler(this.銷退查詢作業ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 337);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "進銷存管理系統";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基本資料管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客戶資料管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客戶資料查詢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 供應商資料管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供應商資料查詢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 庫存資料管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 庫存資料查詢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 進貨管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 進貨處理作業ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 進貨查詢作業ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 進退處理作業ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 銷貨管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 進退查詢作業ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 銷貨處理作業ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 銷貨查詢作業ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 銷退處理作業ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 銷退查詢作業ToolStripMenuItem;

    }
}



