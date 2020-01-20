namespace MouseEvent
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
            this.lblKing = new System.Windows.Forms.Label();
            this.picCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKing
            // 
            this.lblKing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKing.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblKing.Location = new System.Drawing.Point(115, 21);
            this.lblKing.Name = "lblKing";
            this.lblKing.Size = new System.Drawing.Size(95, 96);
            this.lblKing.TabIndex = 3;
            this.lblKing.Text = "Label1";
            // 
            // picCard
            // 
            this.picCard.Location = new System.Drawing.Point(22, 21);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(75, 96);
            this.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCard.TabIndex = 2;
            this.picCard.TabStop = false;
            this.picCard.MouseHover += new System.EventHandler(this.picCard_MouseHover);
            this.picCard.MouseEnter += new System.EventHandler(this.picCard_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 141);
            this.Controls.Add(this.lblKing);
            this.Controls.Add(this.picCard);
            this.Name = "Form1";
            this.Text = "驗證滑鼠事件";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblKing;
        internal System.Windows.Forms.PictureBox picCard;
    }
}

