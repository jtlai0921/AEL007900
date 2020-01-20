namespace runner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.picRunner = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picRunner)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(34, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "原地跑步計時";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(36, 145);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(33, 12);
            this.lblMsg.TabIndex = 8;
            this.lblMsg.Text = "label1";
            // 
            // picRunner
            // 
            this.picRunner.BackColor = System.Drawing.Color.Transparent;
            this.picRunner.Location = new System.Drawing.Point(38, 71);
            this.picRunner.Name = "picRunner";
            this.picRunner.Size = new System.Drawing.Size(68, 57);
            this.picRunner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRunner.TabIndex = 7;
            this.picRunner.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(153, 133);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(51, 24);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(153, 71);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(51, 22);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "RUNNER1.GIF");
            this.imgIcon.Images.SetKeyName(1, "RUNNER2.GIF");
            this.imgIcon.Images.SetKeyName(2, "RUNNER3.GIF");
            this.imgIcon.Images.SetKeyName(3, "RUNNER4.GIF");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 208);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.picRunner);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRunner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox picRunner;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.Timer timer1;
    }
}

