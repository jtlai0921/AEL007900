namespace UpdateDB
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
            System.Windows.Forms.Label 客戶代號Label;
            System.Windows.Forms.Label 客戶名稱Label;
            System.Windows.Forms.Label 統一編號Label;
            System.Windows.Forms.Label 電話Label;
            System.Windows.Forms.Label 傳真Label;
            System.Windows.Forms.Label 信箱Label;
            System.Windows.Forms.Label 住址Label;
            this.客戶BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.客戶BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.客戶代號TextBox = new System.Windows.Forms.TextBox();
            this.客戶名稱TextBox = new System.Windows.Forms.TextBox();
            this.統一編號TextBox = new System.Windows.Forms.TextBox();
            this.電話TextBox = new System.Windows.Forms.TextBox();
            this.傳真TextBox = new System.Windows.Forms.TextBox();
            this.信箱TextBox = new System.Windows.Forms.TextBox();
            this.住址TextBox = new System.Windows.Forms.TextBox();
            this.客戶BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCustomer = new UpdateDB.DataSetCustomer();
            this.客戶TableAdapter = new UpdateDB.DataSetCustomerTableAdapters.客戶TableAdapter();
            this.tableAdapterManager = new UpdateDB.DataSetCustomerTableAdapters.TableAdapterManager();
            客戶代號Label = new System.Windows.Forms.Label();
            客戶名稱Label = new System.Windows.Forms.Label();
            統一編號Label = new System.Windows.Forms.Label();
            電話Label = new System.Windows.Forms.Label();
            傳真Label = new System.Windows.Forms.Label();
            信箱Label = new System.Windows.Forms.Label();
            住址Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.客戶BindingNavigator)).BeginInit();
            this.客戶BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.客戶BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // 客戶BindingNavigator
            // 
            this.客戶BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.客戶BindingNavigator.BindingSource = this.客戶BindingSource;
            this.客戶BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.客戶BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.客戶BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.客戶BindingNavigatorSaveItem});
            this.客戶BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.客戶BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.客戶BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.客戶BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.客戶BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.客戶BindingNavigator.Name = "客戶BindingNavigator";
            this.客戶BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.客戶BindingNavigator.Size = new System.Drawing.Size(368, 25);
            this.客戶BindingNavigator.TabIndex = 0;
            this.客戶BindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // 客戶BindingNavigatorSaveItem
            // 
            this.客戶BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.客戶BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("客戶BindingNavigatorSaveItem.Image")));
            this.客戶BindingNavigatorSaveItem.Name = "客戶BindingNavigatorSaveItem";
            this.客戶BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.客戶BindingNavigatorSaveItem.Text = "儲存資料";
            this.客戶BindingNavigatorSaveItem.Click += new System.EventHandler(this.客戶BindingNavigatorSaveItem_Click);
            // 
            // 客戶代號Label
            // 
            客戶代號Label.AutoSize = true;
            客戶代號Label.Location = new System.Drawing.Point(30, 59);
            客戶代號Label.Name = "客戶代號Label";
            客戶代號Label.Size = new System.Drawing.Size(71, 15);
            客戶代號Label.TabIndex = 1;
            客戶代號Label.Text = "客戶代號:";
            // 
            // 客戶代號TextBox
            // 
            this.客戶代號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.客戶BindingSource, "客戶代號", true));
            this.客戶代號TextBox.Location = new System.Drawing.Point(107, 56);
            this.客戶代號TextBox.Name = "客戶代號TextBox";
            this.客戶代號TextBox.Size = new System.Drawing.Size(100, 25);
            this.客戶代號TextBox.TabIndex = 2;
            // 
            // 客戶名稱Label
            // 
            客戶名稱Label.AutoSize = true;
            客戶名稱Label.Location = new System.Drawing.Point(30, 90);
            客戶名稱Label.Name = "客戶名稱Label";
            客戶名稱Label.Size = new System.Drawing.Size(71, 15);
            客戶名稱Label.TabIndex = 3;
            客戶名稱Label.Text = "客戶名稱:";
            // 
            // 客戶名稱TextBox
            // 
            this.客戶名稱TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.客戶BindingSource, "客戶名稱", true));
            this.客戶名稱TextBox.Location = new System.Drawing.Point(107, 87);
            this.客戶名稱TextBox.Name = "客戶名稱TextBox";
            this.客戶名稱TextBox.Size = new System.Drawing.Size(162, 25);
            this.客戶名稱TextBox.TabIndex = 4;
            // 
            // 統一編號Label
            // 
            統一編號Label.AutoSize = true;
            統一編號Label.Location = new System.Drawing.Point(30, 121);
            統一編號Label.Name = "統一編號Label";
            統一編號Label.Size = new System.Drawing.Size(71, 15);
            統一編號Label.TabIndex = 5;
            統一編號Label.Text = "統一編號:";
            // 
            // 統一編號TextBox
            // 
            this.統一編號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.客戶BindingSource, "統一編號", true));
            this.統一編號TextBox.Location = new System.Drawing.Point(107, 118);
            this.統一編號TextBox.Name = "統一編號TextBox";
            this.統一編號TextBox.Size = new System.Drawing.Size(100, 25);
            this.統一編號TextBox.TabIndex = 6;
            // 
            // 電話Label
            // 
            電話Label.AutoSize = true;
            電話Label.Location = new System.Drawing.Point(30, 152);
            電話Label.Name = "電話Label";
            電話Label.Size = new System.Drawing.Size(41, 15);
            電話Label.TabIndex = 7;
            電話Label.Text = "電話:";
            // 
            // 電話TextBox
            // 
            this.電話TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.客戶BindingSource, "電話", true));
            this.電話TextBox.Location = new System.Drawing.Point(107, 149);
            this.電話TextBox.Name = "電話TextBox";
            this.電話TextBox.Size = new System.Drawing.Size(100, 25);
            this.電話TextBox.TabIndex = 8;
            // 
            // 傳真Label
            // 
            傳真Label.AutoSize = true;
            傳真Label.Location = new System.Drawing.Point(30, 183);
            傳真Label.Name = "傳真Label";
            傳真Label.Size = new System.Drawing.Size(41, 15);
            傳真Label.TabIndex = 9;
            傳真Label.Text = "傳真:";
            // 
            // 傳真TextBox
            // 
            this.傳真TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.客戶BindingSource, "傳真", true));
            this.傳真TextBox.Location = new System.Drawing.Point(107, 180);
            this.傳真TextBox.Name = "傳真TextBox";
            this.傳真TextBox.Size = new System.Drawing.Size(100, 25);
            this.傳真TextBox.TabIndex = 10;
            // 
            // 信箱Label
            // 
            信箱Label.AutoSize = true;
            信箱Label.Location = new System.Drawing.Point(30, 214);
            信箱Label.Name = "信箱Label";
            信箱Label.Size = new System.Drawing.Size(41, 15);
            信箱Label.TabIndex = 11;
            信箱Label.Text = "信箱:";
            // 
            // 信箱TextBox
            // 
            this.信箱TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.客戶BindingSource, "信箱", true));
            this.信箱TextBox.Location = new System.Drawing.Point(107, 211);
            this.信箱TextBox.Name = "信箱TextBox";
            this.信箱TextBox.Size = new System.Drawing.Size(162, 25);
            this.信箱TextBox.TabIndex = 12;
            // 
            // 住址Label
            // 
            住址Label.AutoSize = true;
            住址Label.Location = new System.Drawing.Point(30, 245);
            住址Label.Name = "住址Label";
            住址Label.Size = new System.Drawing.Size(41, 15);
            住址Label.TabIndex = 13;
            住址Label.Text = "住址:";
            // 
            // 住址TextBox
            // 
            this.住址TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.客戶BindingSource, "住址", true));
            this.住址TextBox.Location = new System.Drawing.Point(107, 242);
            this.住址TextBox.Name = "住址TextBox";
            this.住址TextBox.Size = new System.Drawing.Size(238, 25);
            this.住址TextBox.TabIndex = 14;
            // 
            // 客戶BindingSource
            // 
            this.客戶BindingSource.DataMember = "客戶";
            this.客戶BindingSource.DataSource = this.dataSetCustomer;
            // 
            // dataSetCustomer
            // 
            this.dataSetCustomer.DataSetName = "DataSetCustomer";
            this.dataSetCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 客戶TableAdapter
            // 
            this.客戶TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = UpdateDB.DataSetCustomerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.客戶TableAdapter = this.客戶TableAdapter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 298);
            this.Controls.Add(客戶代號Label);
            this.Controls.Add(this.客戶代號TextBox);
            this.Controls.Add(客戶名稱Label);
            this.Controls.Add(this.客戶名稱TextBox);
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
            this.Controls.Add(this.客戶BindingNavigator);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "客戶管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.客戶BindingNavigator)).EndInit();
            this.客戶BindingNavigator.ResumeLayout(false);
            this.客戶BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.客戶BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetCustomer dataSetCustomer;
        private System.Windows.Forms.BindingSource 客戶BindingSource;
        private UpdateDB.DataSetCustomerTableAdapters.客戶TableAdapter 客戶TableAdapter;
        private UpdateDB.DataSetCustomerTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator 客戶BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton 客戶BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox 客戶代號TextBox;
        private System.Windows.Forms.TextBox 客戶名稱TextBox;
        private System.Windows.Forms.TextBox 統一編號TextBox;
        private System.Windows.Forms.TextBox 電話TextBox;
        private System.Windows.Forms.TextBox 傳真TextBox;
        private System.Windows.Forms.TextBox 信箱TextBox;
        private System.Windows.Forms.TextBox 住址TextBox;
    }
}

