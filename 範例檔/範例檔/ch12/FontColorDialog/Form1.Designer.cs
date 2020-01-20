namespace FontColorDialog
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnSetFont = new System.Windows.Forms.Button();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(26, 29);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(203, 68);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "label1";
            // 
            // btnSetFont
            // 
            this.btnSetFont.Location = new System.Drawing.Point(29, 128);
            this.btnSetFont.Name = "btnSetFont";
            this.btnSetFont.Size = new System.Drawing.Size(75, 23);
            this.btnSetFont.TabIndex = 1;
            this.btnSetFont.Text = "設定字型";
            this.btnSetFont.UseVisualStyleBackColor = true;
            this.btnSetFont.Click += new System.EventHandler(this.btnSetFont_Click);
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(133, 128);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(96, 23);
            this.btnSetColor.TabIndex = 2;
            this.btnSetColor.Text = "設定背景顏色";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 178);
            this.Controls.Add(this.btnSetColor);
            this.Controls.Add(this.btnSetFont);
            this.Controls.Add(this.lblMsg);
            this.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "字型與顏色對話方塊";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnSetFont;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

