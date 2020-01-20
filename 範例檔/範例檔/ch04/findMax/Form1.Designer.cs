namespace findMax
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
            this.lblShow = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(42, 83);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(33, 12);
            this.lblShow.TabIndex = 7;
            this.lblShow.Text = "label2";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.Location = new System.Drawing.Point(40, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 19);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "猜猜看哪個按鈕大";
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn2.Location = new System.Drawing.Point(144, 128);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(65, 27);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1.Location = new System.Drawing.Point(44, 127);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(68, 28);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 184);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
    }
}

