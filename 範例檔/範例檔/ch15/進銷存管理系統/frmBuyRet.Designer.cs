﻿namespace 進銷存管理系統
{
    partial class frmBuyRet
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
            this.lblToday = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.btnAddBuyRet = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.lblS2 = new System.Windows.Forms.Label();
            this.lblS1 = new System.Windows.Forms.Label();
            this.cboVendorName = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dataSetDB1 = new 進銷存管理系統.DataSetDB1();
            this.供應商BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.供應商TableAdapter = new 進銷存管理系統.DataSetDB1TableAdapters.供應商TableAdapter();
            this.庫存主檔BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.庫存主檔TableAdapter = new 進銷存管理系統.DataSetDB1TableAdapters.庫存主檔TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.供應商BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.庫存主檔BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Location = new System.Drawing.Point(108, 301);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(58, 15);
            this.lblToday.TabIndex = 46;
            this.lblToday.Text = "lblToday";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(19, 301);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(71, 15);
            this.Label8.TabIndex = 47;
            this.Label8.Text = "進退日期:";
            // 
            // cboProductName
            // 
            this.cboProductName.DataSource = this.庫存主檔BindingSource;
            this.cboProductName.DisplayMember = "品名";
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(111, 54);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(252, 23);
            this.cboProductName.TabIndex = 45;
            this.cboProductName.ValueMember = "品名代號";
            // 
            // btnAddBuyRet
            // 
            this.btnAddBuyRet.Location = new System.Drawing.Point(22, 342);
            this.btnAddBuyRet.Name = "btnAddBuyRet";
            this.btnAddBuyRet.Size = new System.Drawing.Size(75, 23);
            this.btnAddBuyRet.TabIndex = 44;
            this.btnAddBuyRet.Text = "新增進退";
            this.btnAddBuyRet.UseVisualStyleBackColor = true;
            this.btnAddBuyRet.Click += new System.EventHandler(this.btnAddBuyRet_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(111, 259);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(252, 25);
            this.txtNote.TabIndex = 41;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(111, 215);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 25);
            this.txtQty.TabIndex = 42;
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.庫存主檔BindingSource, "進價", true));
            this.txtBuyPrice.Location = new System.Drawing.Point(111, 174);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(100, 25);
            this.txtBuyPrice.TabIndex = 43;
            // 
            // lblS2
            // 
            this.lblS2.AutoSize = true;
            this.lblS2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.庫存主檔BindingSource, "規格", true));
            this.lblS2.Location = new System.Drawing.Point(108, 137);
            this.lblS2.Name = "lblS2";
            this.lblS2.Size = new System.Drawing.Size(37, 15);
            this.lblS2.TabIndex = 40;
            this.lblS2.Text = "lblS2";
            // 
            // lblS1
            // 
            this.lblS1.AutoSize = true;
            this.lblS1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.庫存主檔BindingSource, "單位", true));
            this.lblS1.Location = new System.Drawing.Point(108, 96);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(37, 15);
            this.lblS1.TabIndex = 39;
            this.lblS1.Text = "lblS1";
            // 
            // cboVendorName
            // 
            this.cboVendorName.DataSource = this.供應商BindingSource;
            this.cboVendorName.DisplayMember = "公司名稱";
            this.cboVendorName.FormattingEnabled = true;
            this.cboVendorName.Location = new System.Drawing.Point(111, 16);
            this.cboVendorName.Name = "cboVendorName";
            this.cboVendorName.Size = new System.Drawing.Size(252, 23);
            this.cboVendorName.TabIndex = 38;
            this.cboVendorName.ValueMember = "供應商代號";
            this.cboVendorName.SelectedIndexChanged += new System.EventHandler(this.cboVendorName_SelectedIndexChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(19, 262);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(41, 15);
            this.Label7.TabIndex = 37;
            this.Label7.Text = "備註:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(19, 218);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(41, 15);
            this.Label6.TabIndex = 36;
            this.Label6.Text = "數量:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(19, 177);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(41, 15);
            this.Label5.TabIndex = 35;
            this.Label5.Text = "進價:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(19, 137);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(41, 15);
            this.Label4.TabIndex = 34;
            this.Label4.Text = "規格:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(19, 96);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(41, 15);
            this.Label3.TabIndex = 33;
            this.Label3.Text = "單位:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(19, 57);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(41, 15);
            this.Label2.TabIndex = 32;
            this.Label2.Text = "品名:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(19, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(86, 15);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "供應商名稱:";
            // 
            // dataSetDB1
            // 
            this.dataSetDB1.DataSetName = "DataSetDB1";
            this.dataSetDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 供應商BindingSource
            // 
            this.供應商BindingSource.DataMember = "供應商";
            this.供應商BindingSource.DataSource = this.dataSetDB1;
            // 
            // 供應商TableAdapter
            // 
            this.供應商TableAdapter.ClearBeforeFill = true;
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
            // frmBuyRet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 383);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.cboProductName);
            this.Controls.Add(this.btnAddBuyRet);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtBuyPrice);
            this.Controls.Add(this.lblS2);
            this.Controls.Add(this.lblS1);
            this.Controls.Add(this.cboVendorName);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBuyRet";
            this.Text = "進退處理表單";
            this.Load += new System.EventHandler(this.frmBuyRet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.供應商BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.庫存主檔BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblToday;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.ComboBox cboProductName;
        internal System.Windows.Forms.Button btnAddBuyRet;
        internal System.Windows.Forms.TextBox txtNote;
        internal System.Windows.Forms.TextBox txtQty;
        internal System.Windows.Forms.TextBox txtBuyPrice;
        internal System.Windows.Forms.Label lblS2;
        internal System.Windows.Forms.Label lblS1;
        internal System.Windows.Forms.ComboBox cboVendorName;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private DataSetDB1 dataSetDB1;
        private System.Windows.Forms.BindingSource 供應商BindingSource;
        private 進銷存管理系統.DataSetDB1TableAdapters.供應商TableAdapter 供應商TableAdapter;
        private System.Windows.Forms.BindingSource 庫存主檔BindingSource;
        private 進銷存管理系統.DataSetDB1TableAdapters.庫存主檔TableAdapter 庫存主檔TableAdapter;
    }
}