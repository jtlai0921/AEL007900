namespace 進銷存管理系統
{
    partial class frmSale
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
            this.Label8 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblS2 = new System.Windows.Forms.Label();
            this.lblS1 = new System.Windows.Forms.Label();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.cboCustName = new System.Windows.Forms.ComboBox();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dataSetDB1 = new 進銷存管理系統.DataSetDB1();
            this.客戶BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.客戶TableAdapter = new 進銷存管理系統.DataSetDB1TableAdapters.客戶TableAdapter();
            this.庫存主檔BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.庫存主檔TableAdapter = new 進銷存管理系統.DataSetDB1TableAdapters.庫存主檔TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.庫存主檔BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(22, 206);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(41, 15);
            this.Label8.TabIndex = 24;
            this.Label8.Text = "數量:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(99, 239);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(256, 25);
            this.txtNote.TabIndex = 21;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(99, 203);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 25);
            this.txtQty.TabIndex = 22;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.庫存主檔BindingSource, "售價", true));
            this.txtSalePrice.Location = new System.Drawing.Point(99, 166);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(100, 25);
            this.txtSalePrice.TabIndex = 23;
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Location = new System.Drawing.Point(96, 289);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(58, 15);
            this.lblToday.TabIndex = 19;
            this.lblToday.Text = "lblToday";
            // 
            // lblS2
            // 
            this.lblS2.AutoSize = true;
            this.lblS2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.庫存主檔BindingSource, "規格", true));
            this.lblS2.Location = new System.Drawing.Point(96, 131);
            this.lblS2.Name = "lblS2";
            this.lblS2.Size = new System.Drawing.Size(37, 15);
            this.lblS2.TabIndex = 20;
            this.lblS2.Text = "lblS2";
            // 
            // lblS1
            // 
            this.lblS1.AutoSize = true;
            this.lblS1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.庫存主檔BindingSource, "單位", true));
            this.lblS1.Location = new System.Drawing.Point(96, 90);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(37, 15);
            this.lblS1.TabIndex = 18;
            this.lblS1.Text = "lblS1";
            // 
            // cboProductName
            // 
            this.cboProductName.DataSource = this.庫存主檔BindingSource;
            this.cboProductName.DisplayMember = "品名";
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(99, 51);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(256, 23);
            this.cboProductName.TabIndex = 17;
            this.cboProductName.ValueMember = "品名代號";
            // 
            // cboCustName
            // 
            this.cboCustName.DataSource = this.客戶BindingSource;
            this.cboCustName.DisplayMember = "客戶名稱";
            this.cboCustName.FormattingEnabled = true;
            this.cboCustName.Location = new System.Drawing.Point(99, 16);
            this.cboCustName.Name = "cboCustName";
            this.cboCustName.Size = new System.Drawing.Size(256, 23);
            this.cboCustName.TabIndex = 16;
            this.cboCustName.ValueMember = "客戶代號";
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(25, 331);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(75, 23);
            this.btnAddSale.TabIndex = 15;
            this.btnAddSale.Text = "新增銷貨";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(22, 289);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(71, 15);
            this.Label7.TabIndex = 10;
            this.Label7.Text = "銷貨日期:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(22, 248);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(41, 15);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "備註:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(22, 169);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(41, 15);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "售價:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(22, 131);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(41, 15);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "規格:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(22, 90);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(41, 15);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "單位:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(22, 54);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(41, 15);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "品名:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(22, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 15);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "客戶名稱:";
            // 
            // dataSetDB1
            // 
            this.dataSetDB1.DataSetName = "DataSetDB1";
            this.dataSetDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 客戶BindingSource
            // 
            this.客戶BindingSource.DataMember = "客戶";
            this.客戶BindingSource.DataSource = this.dataSetDB1;
            // 
            // 客戶TableAdapter
            // 
            this.客戶TableAdapter.ClearBeforeFill = true;
            // 
            // 庫存主檔BindingSource
            // 
            this.庫存主檔BindingSource.DataMember = "庫存主檔";
            this.庫存主檔BindingSource.DataSource = this.dataSetDB1;
            // 
            // 庫存主檔TableAdapter
            // 
            this.庫存主檔TableAdapter.ClearBeforeFill = true;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 371);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.lblS2);
            this.Controls.Add(this.lblS1);
            this.Controls.Add(this.cboProductName);
            this.Controls.Add(this.cboCustName);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSale";
            this.Text = "銷貨處理表單";
            this.Load += new System.EventHandler(this.frmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.庫存主檔BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtNote;
        internal System.Windows.Forms.TextBox txtQty;
        internal System.Windows.Forms.TextBox txtSalePrice;
        internal System.Windows.Forms.Label lblToday;
        internal System.Windows.Forms.Label lblS2;
        internal System.Windows.Forms.Label lblS1;
        internal System.Windows.Forms.ComboBox cboProductName;
        internal System.Windows.Forms.ComboBox cboCustName;
        internal System.Windows.Forms.Button btnAddSale;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private DataSetDB1 dataSetDB1;
        private System.Windows.Forms.BindingSource 客戶BindingSource;
        private 進銷存管理系統.DataSetDB1TableAdapters.客戶TableAdapter 客戶TableAdapter;
        private System.Windows.Forms.BindingSource 庫存主檔BindingSource;
        private 進銷存管理系統.DataSetDB1TableAdapters.庫存主檔TableAdapter 庫存主檔TableAdapter;
    }
}