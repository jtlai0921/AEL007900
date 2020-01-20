namespace coupon
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
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "請問我國每位國民發多少金額的消費券?\r\n";
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(27, 89);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(62, 16);
            this.rdb2.TabIndex = 2;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "3,600元";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(27, 111);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(62, 16);
            this.rdb3.TabIndex = 3;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "4,000元";
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Location = new System.Drawing.Point(27, 133);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(62, 16);
            this.rdb4.TabIndex = 4;
            this.rdb4.TabStop = true;
            this.rdb4.Text = "4,500元";
            this.rdb4.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(32, 162);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 12);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "請您作答...";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(164, 126);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(61, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "對答";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(27, 67);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(62, 16);
            this.rdb1.TabIndex = 1;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "3,000元";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 191);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rdb4);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rdb1;
    }
}

