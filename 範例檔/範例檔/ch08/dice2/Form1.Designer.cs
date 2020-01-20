namespace dice2
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
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(24, 80);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(71, 50);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic1.TabIndex = 7;
            this.pic1.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(198, 157);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(71, 33);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "開始";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMsg.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMsg.Location = new System.Drawing.Point(15, 157);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(169, 33);
            this.lblMsg.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(68, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "擲骰子遊戲";
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(113, 80);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(71, 50);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic2.TabIndex = 7;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(198, 80);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(71, 50);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic3.TabIndex = 7;
            this.pic3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 215);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "擲骰子遊戲";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
    }
}

