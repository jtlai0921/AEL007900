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
            this.lblMove = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.Location = new System.Drawing.Point(139, 88);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(33, 12);
            this.lblMove.TabIndex = 0;
            this.lblMove.Text = "label1";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(268, 144);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(38, 31);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "上";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(231, 172);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(38, 31);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "左";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(305, 172);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(38, 31);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = "右";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(268, 200);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(38, 31);
            this.btnDown.TabIndex = 1;
            this.btnDown.Text = "下";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 250);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblMove);
            this.Name = "Form1";
            this.Text = "控制項的移動";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;

    }
}

