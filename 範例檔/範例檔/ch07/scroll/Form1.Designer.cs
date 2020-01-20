namespace scroll
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
            this.hsbWidth = new System.Windows.Forms.HScrollBar();
            this.vsbHeight = new System.Windows.Forms.VScrollBar();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnFlower4 = new System.Windows.Forms.Button();
            this.btnFlower2 = new System.Windows.Forms.Button();
            this.btnFlower3 = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // hsbWidth
            // 
            this.hsbWidth.Location = new System.Drawing.Point(22, 259);
            this.hsbWidth.Name = "hsbWidth";
            this.hsbWidth.Size = new System.Drawing.Size(239, 17);
            this.hsbWidth.TabIndex = 0;
            this.hsbWidth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbWidth_Scroll);
            // 
            // vsbHeight
            // 
            this.vsbHeight.Location = new System.Drawing.Point(274, 21);
            this.vsbHeight.Name = "vsbHeight";
            this.vsbHeight.Size = new System.Drawing.Size(21, 232);
            this.vsbHeight.TabIndex = 1;
            this.vsbHeight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbHeight_Scroll);
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picImage.Location = new System.Drawing.Point(43, 37);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(200, 200);
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(50, 241);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(33, 12);
            this.lblMsg.TabIndex = 4;
            this.lblMsg.Text = "label1";
            // 
            // btnFlower4
            // 
            this.btnFlower4.Location = new System.Drawing.Point(310, 171);
            this.btnFlower4.Name = "btnFlower4";
            this.btnFlower4.Size = new System.Drawing.Size(61, 22);
            this.btnFlower4.TabIndex = 6;
            this.btnFlower4.Text = "炮仗花";
            this.btnFlower4.UseVisualStyleBackColor = true;
            this.btnFlower4.Click += new System.EventHandler(this.btnFlower4_Click);
            // 
            // btnFlower2
            // 
            this.btnFlower2.Location = new System.Drawing.Point(310, 85);
            this.btnFlower2.Name = "btnFlower2";
            this.btnFlower2.Size = new System.Drawing.Size(61, 22);
            this.btnFlower2.TabIndex = 7;
            this.btnFlower2.Text = "牡丹花";
            this.btnFlower2.UseVisualStyleBackColor = true;
            this.btnFlower2.Click += new System.EventHandler(this.btnFlower2_Click);
            // 
            // btnFlower3
            // 
            this.btnFlower3.Location = new System.Drawing.Point(310, 128);
            this.btnFlower3.Name = "btnFlower3";
            this.btnFlower3.Size = new System.Drawing.Size(61, 22);
            this.btnFlower3.TabIndex = 8;
            this.btnFlower3.Text = "百合花";
            this.btnFlower3.UseVisualStyleBackColor = true;
            this.btnFlower3.Click += new System.EventHandler(this.btnFlower3_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(310, 215);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(61, 22);
            this.btnEnd.TabIndex = 10;
            this.btnEnd.Text = "結束";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "鬱金香";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnFlower3);
            this.Controls.Add(this.btnFlower2);
            this.Controls.Add(this.btnFlower4);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.vsbHeight);
            this.Controls.Add(this.hsbWidth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hsbWidth;
        private System.Windows.Forms.VScrollBar vsbHeight;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnFlower4;
        private System.Windows.Forms.Button btnFlower2;
        private System.Windows.Forms.Button btnFlower3;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button button1;
    }
}

