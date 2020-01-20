namespace tooltip
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
            this.components = new System.ComponentModel.Container();
            this.btnOK = new System.Windows.Forms.Button();
            this.mtbMobile = new System.Windows.Forms.MaskedTextBox();
            this.mtbTel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbEng = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbChin = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOK.Location = new System.Drawing.Point(252, 207);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 28);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "確定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // mtbMobile
            // 
            this.mtbMobile.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mtbMobile.Location = new System.Drawing.Point(100, 207);
            this.mtbMobile.Name = "mtbMobile";
            this.mtbMobile.Size = new System.Drawing.Size(120, 27);
            this.mtbMobile.TabIndex = 18;
            this.mtbMobile.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbMobile_MaskInputRejected);
            // 
            // mtbTel
            // 
            this.mtbTel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mtbTel.Location = new System.Drawing.Point(100, 173);
            this.mtbTel.Name = "mtbTel";
            this.mtbTel.Size = new System.Drawing.Size(121, 27);
            this.mtbTel.TabIndex = 17;
            this.mtbTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbTel_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(19, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "手      機";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(19, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "電       話";
            // 
            // mtbEng
            // 
            this.mtbEng.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mtbEng.Location = new System.Drawing.Point(99, 137);
            this.mtbEng.Name = "mtbEng";
            this.mtbEng.Size = new System.Drawing.Size(136, 27);
            this.mtbEng.TabIndex = 14;
            this.mtbEng.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbEng_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(19, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "英文姓名";
            // 
            // mtbChin
            // 
            this.mtbChin.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mtbChin.Location = new System.Drawing.Point(100, 100);
            this.mtbChin.Name = "mtbChin";
            this.mtbChin.Size = new System.Drawing.Size(100, 27);
            this.mtbChin.TabIndex = 12;
            this.mtbChin.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbChin_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(19, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "中文姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "會員登錄作業";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 266);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.mtbMobile);
            this.Controls.Add(this.mtbTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtbEng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbChin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.MaskedTextBox mtbMobile;
        private System.Windows.Forms.MaskedTextBox mtbTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbEng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbChin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}

