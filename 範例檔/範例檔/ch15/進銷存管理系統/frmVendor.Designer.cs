namespace 進銷存管理系統
{
    partial class frmVendor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendor));
            System.Windows.Forms.Label 供應商代號Label;
            System.Windows.Forms.Label 公司名稱Label;
            System.Windows.Forms.Label 統一編號Label;
            System.Windows.Forms.Label 電話Label;
            System.Windows.Forms.Label 傳真Label;
            System.Windows.Forms.Label 信箱Label;
            System.Windows.Forms.Label 住址Label;
            this.dataSetDB1 = new 進銷存管理系統.DataSetDB1();
            this.供應商BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.供應商TableAdapter = new 進銷存管理系統.DataSetDB1TableAdapters.供應商TableAdapter();
            this.tableAdapterManager = new 進銷存管理系統.DataSetDB1TableAdapters.TableAdapterManager();
            this.供應商BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.供應商BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.供應商代號TextBox = new System.Windows.Forms.TextBox();
            this.公司名稱TextBox = new System.Windows.Forms.TextBox();
            this.統一編號TextBox = new System.Windows.Forms.TextBox();
            this.電話TextBox = new System.Windows.Forms.TextBox();
            this.傳真TextBox = new System.Windows.Forms.TextBox();
            this.信箱TextBox = new System.Windows.Forms.TextBox();
            this.住址TextBox = new System.Windows.Forms.TextBox();
            供應商代號Label = new System.Windows.Forms.Label();
            公司名稱Label = new System.Windows.Forms.Label();
            統一編號Label = new System.Windows.Forms.Label();
            電話Label = new System.Windows.Forms.Label();
            傳真Label = new System.Windows.Forms.Label();
            信箱Label = new System.Windows.Forms.Label();
            住址Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.供應商BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.供應商BindingNavigator)).BeginInit();
            this.供應商BindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = 進銷存管理系統.DataSetDB1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.供應商TableAdapter = this.供應商TableAdapter;
            this.tableAdapterManager.客戶TableAdapter = null;
            this.tableAdapterManager.庫存主檔TableAdapter = null;
            // 
            // 供應商BindingNavigator
            // 
            this.供應商BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.供應商BindingNavigator.BindingSource = this.供應商BindingSource;
            this.供應商BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.供應商BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.供應商BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.供應商BindingNavigatorSaveItem});
            this.供應商BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.供應商BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.供應商BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.供應商BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.供應商BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.供應商BindingNavigator.Name = "供應商BindingNavigator";
            this.供應商BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.供應商BindingNavigator.Size = new System.Drawing.Size(419, 25);
            this.供應商BindingNavigator.TabIndex = 0;
            this.供應商BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 22);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(24, 12);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // 供應商BindingNavigatorSaveItem
            // 
            this.供應商BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.供應商BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("供應商BindingNavigatorSaveItem.Image")));
            this.供應商BindingNavigatorSaveItem.Name = "供應商BindingNavigatorSaveItem";
            this.供應商BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.供應商BindingNavigatorSaveItem.Text = "儲存資料";
            this.供應商BindingNavigatorSaveItem.Click += new System.EventHandler(this.供應商BindingNavigatorSaveItem_Click);
            // 
            // 供應商代號Label
            // 
            供應商代號Label.AutoSize = true;
            供應商代號Label.Location = new System.Drawing.Point(32, 52);
            供應商代號Label.Name = "供應商代號Label";
            供應商代號Label.Size = new System.Drawing.Size(86, 15);
            供應商代號Label.TabIndex = 1;
            供應商代號Label.Text = "供應商代號:";
            // 
            // 供應商代號TextBox
            // 
            this.供應商代號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.供應商BindingSource, "供應商代號", true));
            this.供應商代號TextBox.Location = new System.Drawing.Point(124, 49);
            this.供應商代號TextBox.Name = "供應商代號TextBox";
            this.供應商代號TextBox.Size = new System.Drawing.Size(100, 25);
            this.供應商代號TextBox.TabIndex = 2;
            // 
            // 公司名稱Label
            // 
            公司名稱Label.AutoSize = true;
            公司名稱Label.Location = new System.Drawing.Point(32, 83);
            公司名稱Label.Name = "公司名稱Label";
            公司名稱Label.Size = new System.Drawing.Size(71, 15);
            公司名稱Label.TabIndex = 3;
            公司名稱Label.Text = "公司名稱:";
            // 
            // 公司名稱TextBox
            // 
            this.公司名稱TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.供應商BindingSource, "公司名稱", true));
            this.公司名稱TextBox.Location = new System.Drawing.Point(124, 80);
            this.公司名稱TextBox.Name = "公司名稱TextBox";
            this.公司名稱TextBox.Size = new System.Drawing.Size(207, 25);
            this.公司名稱TextBox.TabIndex = 4;
            // 
            // 統一編號Label
            // 
            統一編號Label.AutoSize = true;
            統一編號Label.Location = new System.Drawing.Point(32, 114);
            統一編號Label.Name = "統一編號Label";
            統一編號Label.Size = new System.Drawing.Size(71, 15);
            統一編號Label.TabIndex = 5;
            統一編號Label.Text = "統一編號:";
            // 
            // 統一編號TextBox
            // 
            this.統一編號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.供應商BindingSource, "統一編號", true));
            this.統一編號TextBox.Location = new System.Drawing.Point(124, 111);
            this.統一編號TextBox.Name = "統一編號TextBox";
            this.統一編號TextBox.Size = new System.Drawing.Size(100, 25);
            this.統一編號TextBox.TabIndex = 6;
            // 
            // 電話Label
            // 
            電話Label.AutoSize = true;
            電話Label.Location = new System.Drawing.Point(32, 145);
            電話Label.Name = "電話Label";
            電話Label.Size = new System.Drawing.Size(41, 15);
            電話Label.TabIndex = 7;
            電話Label.Text = "電話:";
            // 
            // 電話TextBox
            // 
            this.電話TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.供應商BindingSource, "電話", true));
            this.電話TextBox.Location = new System.Drawing.Point(124, 142);
            this.電話TextBox.Name = "電話TextBox";
            this.電話TextBox.Size = new System.Drawing.Size(100, 25);
            this.電話TextBox.TabIndex = 8;
            // 
            // 傳真Label
            // 
            傳真Label.AutoSize = true;
            傳真Label.Location = new System.Drawing.Point(32, 176);
            傳真Label.Name = "傳真Label";
            傳真Label.Size = new System.Drawing.Size(41, 15);
            傳真Label.TabIndex = 9;
            傳真Label.Text = "傳真:";
            // 
            // 傳真TextBox
            // 
            this.傳真TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.供應商BindingSource, "傳真", true));
            this.傳真TextBox.Location = new System.Drawing.Point(124, 173);
            this.傳真TextBox.Name = "傳真TextBox";
            this.傳真TextBox.Size = new System.Drawing.Size(100, 25);
            this.傳真TextBox.TabIndex = 10;
            // 
            // 信箱Label
            // 
            信箱Label.AutoSize = true;
            信箱Label.Location = new System.Drawing.Point(32, 207);
            信箱Label.Name = "信箱Label";
            信箱Label.Size = new System.Drawing.Size(41, 15);
            信箱Label.TabIndex = 11;
            信箱Label.Text = "信箱:";
            // 
            // 信箱TextBox
            // 
            this.信箱TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.供應商BindingSource, "信箱", true));
            this.信箱TextBox.Location = new System.Drawing.Point(124, 204);
            this.信箱TextBox.Name = "信箱TextBox";
            this.信箱TextBox.Size = new System.Drawing.Size(207, 25);
            this.信箱TextBox.TabIndex = 12;
            // 
            // 住址Label
            // 
            住址Label.AutoSize = true;
            住址Label.Location = new System.Drawing.Point(32, 238);
            住址Label.Name = "住址Label";
            住址Label.Size = new System.Drawing.Size(41, 15);
            住址Label.TabIndex = 13;
            住址Label.Text = "住址:";
            // 
            // 住址TextBox
            // 
            this.住址TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.供應商BindingSource, "住址", true));
            this.住址TextBox.Location = new System.Drawing.Point(124, 235);
            this.住址TextBox.Name = "住址TextBox";
            this.住址TextBox.Size = new System.Drawing.Size(283, 25);
            this.住址TextBox.TabIndex = 14;
            // 
            // frmVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 282);
            this.Controls.Add(供應商代號Label);
            this.Controls.Add(this.供應商代號TextBox);
            this.Controls.Add(公司名稱Label);
            this.Controls.Add(this.公司名稱TextBox);
            this.Controls.Add(統一編號Label);
            this.Controls.Add(this.統一編號TextBox);
            this.Controls.Add(電話Label);
            this.Controls.Add(this.電話TextBox);
            this.Controls.Add(傳真Label);
            this.Controls.Add(this.傳真TextBox);
            this.Controls.Add(信箱Label);
            this.Controls.Add(this.信箱TextBox);
            this.Controls.Add(住址Label);
            this.Controls.Add(this.住址TextBox);
            this.Controls.Add(this.供應商BindingNavigator);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVendor";
            this.Text = "供應商資料管理表單";
            this.Load += new System.EventHandler(this.frmVendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.供應商BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.供應商BindingNavigator)).EndInit();
            this.供應商BindingNavigator.ResumeLayout(false);
            this.供應商BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetDB1 dataSetDB1;
        private System.Windows.Forms.BindingSource 供應商BindingSource;
        private 進銷存管理系統.DataSetDB1TableAdapters.供應商TableAdapter 供應商TableAdapter;
        private 進銷存管理系統.DataSetDB1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator 供應商BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton 供應商BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox 供應商代號TextBox;
        private System.Windows.Forms.TextBox 公司名稱TextBox;
        private System.Windows.Forms.TextBox 統一編號TextBox;
        private System.Windows.Forms.TextBox 電話TextBox;
        private System.Windows.Forms.TextBox 傳真TextBox;
        private System.Windows.Forms.TextBox 信箱TextBox;
        private System.Windows.Forms.TextBox 住址TextBox;
    }
}