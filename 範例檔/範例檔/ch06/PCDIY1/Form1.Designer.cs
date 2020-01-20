namespace PCDIY1
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
            this.lstdeskPC = new System.Windows.Forms.ListBox();
            this.cbxCRT = new System.Windows.Forms.ComboBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(98, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PC DIY配件試算";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "主機廠牌";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "液晶螢幕尺寸";
            // 
            // lstdeskPC
            // 
            this.lstdeskPC.FormattingEnabled = true;
            this.lstdeskPC.ItemHeight = 15;
            this.lstdeskPC.Location = new System.Drawing.Point(53, 105);
            this.lstdeskPC.Name = "lstdeskPC";
            this.lstdeskPC.Size = new System.Drawing.Size(120, 94);
            this.lstdeskPC.TabIndex = 3;
            this.lstdeskPC.SelectedIndexChanged += new System.EventHandler(this.lstdeskPC_SelectedIndexChanged);
            // 
            // cbxCRT
            // 
            this.cbxCRT.FormattingEnabled = true;
            this.cbxCRT.Location = new System.Drawing.Point(229, 105);
            this.cbxCRT.Name = "cbxCRT";
            this.cbxCRT.Size = new System.Drawing.Size(121, 23);
            this.cbxCRT.TabIndex = 4;
            this.cbxCRT.SelectedIndexChanged += new System.EventHandler(this.cbxCRT_SelectedIndexChanged);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(226, 184);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(52, 15);
            this.lblSum.TabIndex = 5;
            this.lblSum.Text = "合計：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 238);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.cbxCRT);
            this.Controls.Add(this.lstdeskPC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "清單和下拉式清單應用程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstdeskPC;
        private System.Windows.Forms.ComboBox cbxCRT;
        private System.Windows.Forms.Label lblSum;
    }
}

