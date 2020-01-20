namespace ListTest
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
            this.Label2 = new System.Windows.Forms.Label();
            this.btnReplay = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label2.Location = new System.Drawing.Point(27, 80);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 16);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "單字 :";
            // 
            // btnReplay
            // 
            this.btnReplay.Location = new System.Drawing.Point(213, 92);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(60, 24);
            this.btnReplay.TabIndex = 14;
            this.btnReplay.Text = "重聽";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(213, 122);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(60, 22);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "對答";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMsg.Location = new System.Drawing.Point(27, 137);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(51, 16);
            this.lblMsg.TabIndex = 12;
            this.lblMsg.Text = "lblMsg";
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(213, 150);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(60, 24);
            this.btnEnd.TabIndex = 10;
            this.btnEnd.Text = "結束";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(213, 62);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(60, 24);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "播放";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label1.Location = new System.Drawing.Point(48, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(178, 21);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "英文數字聽力練習";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInput.Location = new System.Drawing.Point(79, 74);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(110, 27);
            this.txtInput.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 191);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "英文聽力練習";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnReplay;
        internal System.Windows.Forms.Button btnCheck;
        internal System.Windows.Forms.Label lblMsg;
        internal System.Windows.Forms.Button btnEnd;
        internal System.Windows.Forms.Button btnPlay;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtInput;
    }
}

