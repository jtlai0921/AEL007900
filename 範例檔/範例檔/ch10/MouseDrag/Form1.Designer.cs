namespace MouseDrag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBlack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // picBlack
            // 
            this.picBlack.BackColor = System.Drawing.Color.Transparent;
            this.picBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBlack.Image = ((System.Drawing.Image)(resources.GetObject("picBlack.Image")));
            this.picBlack.Location = new System.Drawing.Point(54, 49);
            this.picBlack.Name = "picBlack";
            this.picBlack.Size = new System.Drawing.Size(46, 46);
            this.picBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBlack.TabIndex = 4;
            this.picBlack.TabStop = false;
            this.picBlack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBlack_MouseMove);
            this.picBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBlack_MouseDown);
            this.picBlack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBlack_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MouseDrag.Properties.Resources.BackImage;
            this.ClientSize = new System.Drawing.Size(213, 212);
            this.Controls.Add(this.picBlack);
            this.Name = "Form1";
            this.Text = "拖曳範例";
            ((System.ComponentModel.ISupportInitialize)(this.picBlack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox picBlack;

    }
}

