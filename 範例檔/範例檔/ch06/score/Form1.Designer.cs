namespace score
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
            this.btnScore = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 130);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(207, 25);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(91, 23);
            this.btnScore.TabIndex = 1;
            this.btnScore.Text = "原始成績";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(207, 70);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(91, 23);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "依成績排名";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(207, 117);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(91, 23);
            this.btnPass.TabIndex = 2;
            this.btnPass.Text = "查詢及格名單";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 188);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnPass;
    }
}

