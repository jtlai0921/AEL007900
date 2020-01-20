namespace numUpDown
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
            this.picImage = new System.Windows.Forms.PictureBox();
            this.vsbHeight = new System.Windows.Forms.VScrollBar();
            this.hsbWidth = new System.Windows.Forms.HScrollBar();
            this.nudImage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(29, 289);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(33, 12);
            this.lblMsg.TabIndex = 14;
            this.lblMsg.Text = "label1";
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picImage.Location = new System.Drawing.Point(31, 79);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(172, 169);
            this.picImage.TabIndex = 13;
            this.picImage.TabStop = false;
            // 
            // vsbHeight
            // 
            this.vsbHeight.Location = new System.Drawing.Point(248, 79);
            this.vsbHeight.Name = "vsbHeight";
            this.vsbHeight.Size = new System.Drawing.Size(21, 200);
            this.vsbHeight.TabIndex = 12;
            this.vsbHeight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbHeight_Scroll);
            // 
            // hsbWidth
            // 
            this.hsbWidth.Location = new System.Drawing.Point(31, 314);
            this.hsbWidth.Name = "hsbWidth";
            this.hsbWidth.Size = new System.Drawing.Size(201, 17);
            this.hsbWidth.TabIndex = 11;
            this.hsbWidth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbWidth_Scroll);
            // 
            // nudImage
            // 
            this.nudImage.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nudImage.Location = new System.Drawing.Point(123, 25);
            this.nudImage.Name = "nudImage";
            this.nudImage.Size = new System.Drawing.Size(46, 25);
            this.nudImage.TabIndex = 20;
            this.nudImage.ValueChanged += new System.EventHandler(this.nudImage_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "選取圖片編號";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(214, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 22);
            this.button1.TabIndex = 22;
            this.button1.Text = "結束";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudImage);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.vsbHeight);
            this.Controls.Add(this.hsbWidth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.VScrollBar vsbHeight;
        private System.Windows.Forms.HScrollBar hsbWidth;
        private System.Windows.Forms.NumericUpDown nudImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

