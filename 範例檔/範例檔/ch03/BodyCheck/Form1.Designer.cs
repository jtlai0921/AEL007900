namespace WindowsFormsApplication1
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
            this.txtTall = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnMan = new System.Windows.Forms.Button();
            this.btnWoman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入身高(單位：公分)";
            // 
            // txtTall
            // 
            this.txtTall.Location = new System.Drawing.Point(43, 66);
            this.txtTall.Name = "txtTall";
            this.txtTall.Size = new System.Drawing.Size(164, 25);
            this.txtTall.TabIndex = 1;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(43, 128);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(164, 25);
            this.txtWeight.TabIndex = 2;
            // 
            // btnMan
            // 
            this.btnMan.Location = new System.Drawing.Point(43, 187);
            this.btnMan.Name = "btnMan";
            this.btnMan.Size = new System.Drawing.Size(75, 23);
            this.btnMan.TabIndex = 3;
            this.btnMan.Text = "男生";
            this.btnMan.UseVisualStyleBackColor = true;
            this.btnMan.Click += new System.EventHandler(this.btnMan_Click);
            // 
            // btnWoman
            // 
            this.btnWoman.Location = new System.Drawing.Point(133, 187);
            this.btnWoman.Name = "btnWoman";
            this.btnWoman.Size = new System.Drawing.Size(75, 23);
            this.btnWoman.TabIndex = 4;
            this.btnWoman.Text = "女生";
            this.btnWoman.UseVisualStyleBackColor = true;
            this.btnWoman.Click += new System.EventHandler(this.btnWoman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 237);
            this.Controls.Add(this.btnWoman);
            this.Controls.Add(this.btnMan);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtTall);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Form1";
            this.Text = "計算標準體重程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTall;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnMan;
        private System.Windows.Forms.Button btnWoman;

    }
}

