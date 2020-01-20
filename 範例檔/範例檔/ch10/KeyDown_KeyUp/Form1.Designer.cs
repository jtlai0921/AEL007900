namespace 鍵盤事件測試
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
            this.picRider = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRider)).BeginInit();
            this.SuspendLayout();
            // 
            // picRider
            // 
            this.picRider.Location = new System.Drawing.Point(12, 61);
            this.picRider.Name = "picRider";
            this.picRider.Size = new System.Drawing.Size(103, 62);
            this.picRider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRider.TabIndex = 11;
            this.picRider.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label1.Location = new System.Drawing.Point(0, 124);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(347, 43);
            this.Label1.TabIndex = 14;
            // 
            // lblState
            // 
            this.lblState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblState.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblState.Location = new System.Drawing.Point(26, 8);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(80, 23);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "停止!!";
            // 
            // lblKey
            // 
            this.lblKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblKey.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblKey.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblKey.Location = new System.Drawing.Point(129, 8);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(192, 23);
            this.lblKey.TabIndex = 13;
            this.lblKey.Text = "未按鍵!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 166);
            this.Controls.Add(this.picRider);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblKey);
            this.Name = "Form1";
            this.Text = "鍵盤事件測試";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picRider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox picRider;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblState;
        internal System.Windows.Forms.Label lblKey;
    }
}

