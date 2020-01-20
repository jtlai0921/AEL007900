namespace scoreAvg
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
            this.lblN = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(23, 27);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(41, 15);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "label1";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(137, 24);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 25);
            this.txtScore.TabIndex = 1;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(263, 24);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 3;
            this.btnInput.Text = "輸入成績";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(263, 78);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(75, 23);
            this.btnAvg.TabIndex = 3;
            this.btnAvg.Text = "計算平均";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMsg.Location = new System.Drawing.Point(84, 78);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(153, 134);
            this.lblMsg.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 241);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblN);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "輸入成績並計算平均程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Label lblMsg;
    }
}

