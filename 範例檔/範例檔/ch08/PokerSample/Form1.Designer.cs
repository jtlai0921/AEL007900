namespace PokerSample
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(24, 108);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(73, 97);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 17;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(112, 108);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(73, 97);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 18;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(200, 108);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(73, 97);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3.TabIndex = 14;
            this.pic3.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.Location = new System.Drawing.Point(288, 108);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(73, 97);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic4.TabIndex = 15;
            this.pic4.TabStop = false;
            // 
            // pic5
            // 
            this.pic5.Location = new System.Drawing.Point(376, 108);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(73, 97);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic5.TabIndex = 16;
            this.pic5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 232);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "撲克牌發牌範例";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.PictureBox pic1;
        internal System.Windows.Forms.PictureBox pic2;
        internal System.Windows.Forms.PictureBox pic3;
        internal System.Windows.Forms.PictureBox pic4;
        internal System.Windows.Forms.PictureBox pic5;
    }
}

