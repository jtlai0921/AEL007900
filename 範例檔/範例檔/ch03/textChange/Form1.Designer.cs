namespace textChange
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPriceL = new System.Windows.Forms.Label();
            this.lblPriceS = new System.Windows.Forms.Label();
            this.txtQtyL = new System.Windows.Forms.TextBox();
            this.txtQtyS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSumL = new System.Windows.Forms.Label();
            this.lblSumS = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "單價";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "張數";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "金額";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "全票";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "半票";
            // 
            // lblPriceL
            // 
            this.lblPriceL.AutoSize = true;
            this.lblPriceL.Location = new System.Drawing.Point(77, 67);
            this.lblPriceL.Name = "lblPriceL";
            this.lblPriceL.Size = new System.Drawing.Size(28, 15);
            this.lblPriceL.TabIndex = 0;
            this.lblPriceL.Text = "250";
            // 
            // lblPriceS
            // 
            this.lblPriceS.AutoSize = true;
            this.lblPriceS.Location = new System.Drawing.Point(77, 112);
            this.lblPriceS.Name = "lblPriceS";
            this.lblPriceS.Size = new System.Drawing.Size(28, 15);
            this.lblPriceS.TabIndex = 0;
            this.lblPriceS.Text = "150";
            // 
            // txtQtyL
            // 
            this.txtQtyL.Location = new System.Drawing.Point(125, 64);
            this.txtQtyL.Name = "txtQtyL";
            this.txtQtyL.Size = new System.Drawing.Size(55, 25);
            this.txtQtyL.TabIndex = 3;
            this.txtQtyL.TextChanged += new System.EventHandler(this.txtQtyL_TextChanged);
            this.txtQtyL.Enter += new System.EventHandler(this.txtQtyL_Enter);
            // 
            // txtQtyS
            // 
            this.txtQtyS.Location = new System.Drawing.Point(125, 109);
            this.txtQtyS.Name = "txtQtyS";
            this.txtQtyS.Size = new System.Drawing.Size(55, 25);
            this.txtQtyS.TabIndex = 3;
            this.txtQtyS.TextChanged += new System.EventHandler(this.txtQtyL_TextChanged);
            this.txtQtyS.Enter += new System.EventHandler(this.txtQtyS_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "合計";
            // 
            // lblSumL
            // 
            this.lblSumL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSumL.Location = new System.Drawing.Point(196, 67);
            this.lblSumL.Name = "lblSumL";
            this.lblSumL.Size = new System.Drawing.Size(58, 22);
            this.lblSumL.TabIndex = 2;
            // 
            // lblSumS
            // 
            this.lblSumS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSumS.Location = new System.Drawing.Point(196, 112);
            this.lblSumS.Name = "lblSumS";
            this.lblSumS.Size = new System.Drawing.Size(58, 22);
            this.lblSumS.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotal.Location = new System.Drawing.Point(196, 157);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 22);
            this.lblTotal.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 206);
            this.Controls.Add(this.txtQtyS);
            this.Controls.Add(this.txtQtyL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSumS);
            this.Controls.Add(this.lblSumL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPriceS);
            this.Controls.Add(this.lblPriceL);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "電影院售票程式";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPriceL;
        private System.Windows.Forms.Label lblPriceS;
        private System.Windows.Forms.TextBox txtQtyL;
        private System.Windows.Forms.TextBox txtQtyS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSumL;
        private System.Windows.Forms.Label lblSumS;
        private System.Windows.Forms.Label lblTotal;
    }
}

