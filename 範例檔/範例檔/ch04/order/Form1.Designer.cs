namespace order
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(94, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "碁峰點餐系統";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb3);
            this.groupBox1.Controls.Add(this.rdb2);
            this.groupBox1.Controls.Add(this.rdb1);
            this.groupBox1.Location = new System.Drawing.Point(31, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主餐";
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(10, 77);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(109, 16);
            this.rdb3.TabIndex = 1;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "麥香雞塊(110元)\r\n";
            this.rdb3.UseVisualStyleBackColor = true;
            this.rdb3.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(10, 48);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(91, 16);
            this.rdb2.TabIndex = 1;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "麥香魚(90元)";
            this.rdb2.UseVisualStyleBackColor = true;
            this.rdb2.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(10, 21);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(97, 16);
            this.rdb1.TabIndex = 0;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "麥香雞(100元)";
            this.rdb1.UseVisualStyleBackColor = true;
            this.rdb1.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk3);
            this.groupBox2.Controls.Add(this.chk2);
            this.groupBox2.Controls.Add(this.chk1);
            this.groupBox2.Location = new System.Drawing.Point(183, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 104);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "附餐";
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(11, 77);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(104, 16);
            this.chk3.TabIndex = 2;
            this.chk3.Text = "玉米濃湯(40元)";
            this.chk3.UseVisualStyleBackColor = true;
            this.chk3.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(11, 48);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(83, 16);
            this.chk2.TabIndex = 1;
            this.chk2.Text = "薯條( 30元)";
            this.chk2.UseVisualStyleBackColor = true;
            this.chk2.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(11, 21);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(80, 16);
            this.chk1.TabIndex = 0;
            this.chk1.Text = "可樂(20元)";
            this.chk1.UseVisualStyleBackColor = true;
            this.chk1.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSum.Location = new System.Drawing.Point(38, 204);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(41, 15);
            this.lblSum.TabIndex = 3;
            this.lblSum.Text = "label2";
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(235, 206);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(62, 26);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "結束";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 249);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.Button btnEnd;
    }
}

