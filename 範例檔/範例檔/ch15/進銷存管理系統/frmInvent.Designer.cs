namespace 進銷存管理系統
{
    partial class frmInvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvent));
            System.Windows.Forms.Label 品名代號Label;
            System.Windows.Forms.Label 品名Label;
            System.Windows.Forms.Label 供應商代號Label;
            System.Windows.Forms.Label 單位Label;
            System.Windows.Forms.Label 規格Label;
            System.Windows.Forms.Label 進價Label;
            System.Windows.Forms.Label 售價Label;
            System.Windows.Forms.Label 庫存量Label;
            this.dataSetDB1 = new 進銷存管理系統.DataSetDB1();
            this.庫存主檔BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.庫存主檔TableAdapter = new 進銷存管理系統.DataSetDB1TableAdapters.庫存主檔TableAdapter();
            this.tableAdapterManager = new 進銷存管理系統.DataSetDB1TableAdapters.TableAdapterManager();
            this.庫存主檔BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.庫存主檔BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.品名代號TextBox = new System.Windows.Forms.TextBox();
            this.品名TextBox = new System.Windows.Forms.TextBox();
            this.供應商代號TextBox = new System.Windows.Forms.TextBox();
            this.單位TextBox = new System.Windows.Forms.TextBox();
            this.規格TextBox = new System.Windows.Forms.TextBox();
            this.進價TextBox = new System.Windows.Forms.TextBox();
            this.售價TextBox = new System.Windows.Forms.TextBox();
            this.庫存量TextBox = new System.Windows.Forms.TextBox();
            品名代號Label = new System.Windows.Forms.Label();
            品名Label = new System.Windows.Forms.Label();
            供應商代號Label = new System.Windows.Forms.Label();
            單位Label = new System.Windows.Forms.Label();
            規格Label = new System.Windows.Forms.Label();
            進價Label = new System.Windows.Forms.Label();
            售價Label = new System.Windows.Forms.Label();
            庫存量Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.庫存主檔BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.庫存主檔BindingNavigator)).BeginInit();
            this.庫存主檔BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSetDB1
            // 
            this.dataSetDB1.DataSetName = "DataSetDB1";
            this.dataSetDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = 進銷存管理系統.DataSetDB1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.供應商TableAdapter = null;
            this.tableAdapterManager.客戶TableAdapter = null;
            this.tableAdapterManager.庫存主檔TableAdapter = this.庫存主檔TableAdapter;
            // 
            // 庫存主檔BindingNavigator
            // 
            this.庫存主檔BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.庫存主檔BindingNavigator.BindingSource = this.庫存主檔BindingSource;
            this.庫存主檔BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.庫存主檔BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.庫存主檔BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.庫存主檔BindingNavigatorSaveItem});
            this.庫存主檔BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.庫存主檔BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.庫存主檔BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.庫存主檔BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.庫存主檔BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.庫存主檔BindingNavigator.Name = "庫存主檔BindingNavigator";
            this.庫存主檔BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.庫存主檔BindingNavigator.Size = new System.Drawing.Size(383, 25);
            this.庫存主檔BindingNavigator.TabIndex = 0;
            this.庫存主檔BindingNavigator.Text = "bindingNavigator1";
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
            // 庫存主檔BindingNavigatorSaveItem
            // 
            this.庫存主檔BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.庫存主檔BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("庫存主檔BindingNavigatorSaveItem.Image")));
            this.庫存主檔BindingNavigatorSaveItem.Name = "庫存主檔BindingNavigatorSaveItem";
            this.庫存主檔BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.庫存主檔BindingNavigatorSaveItem.Text = "儲存資料";
            this.庫存主檔BindingNavigatorSaveItem.Click += new System.EventHandler(this.庫存主檔BindingNavigatorSaveItem_Click);
            // 
            // 品名代號Label
            // 
            品名代號Label.AutoSize = true;
            品名代號Label.Location = new System.Drawing.Point(25, 54);
            品名代號Label.Name = "品名代號Label";
            品名代號Label.Size = new System.Drawing.Size(71, 15);
            品名代號Label.TabIndex = 1;
            品名代號Label.Text = "品名代號:";
            // 
            // 品名代號TextBox
            // 
            this.品名代號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.庫存主檔BindingSource, "品名代號", true));
            this.品名代號TextBox.Location = new System.Drawing.Point(117, 51);
            this.品名代號TextBox.Name = "品名代號TextBox";
            this.品名代號TextBox.Size = new System.Drawing.Size(100, 25);
            this.品名代號TextBox.TabIndex = 2;
            // 
            // 品名Label
            // 
            品名Label.AutoSize = true;
            品名Label.Location = new System.Drawing.Point(25, 85);
            品名Label.Name = "品名Label";
            品名Label.Size = new System.Drawing.Size(41, 15);
            品名Label.TabIndex = 3;
            品名Label.Text = "品名:";
            // 
            // 品名TextBox
            // 
            this.品名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.庫存主檔BindingSource, "品名", true));
            this.品名TextBox.Location = new System.Drawing.Point(117, 82);
            this.品名TextBox.Name = "品名TextBox";
            this.品名TextBox.Size = new System.Drawing.Size(254, 25);
            this.品名TextBox.TabIndex = 4;
            // 
            // 供應商代號Label
            // 
            供應商代號Label.AutoSize = true;
            供應商代號Label.Location = new System.Drawing.Point(25, 116);
            供應商代號Label.Name = "供應商代號Label";
            供應商代號Label.Size = new System.Drawing.Size(86, 15);
            供應商代號Label.TabIndex = 5;
            供應商代號Label.Text = "供應商代號:";
            // 
            // 供應商代號TextBox
            // 
            this.供應商代號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.庫存主檔BindingSource, "供應商代號", true));
            this.供應商代號TextBox.Location = new System.Drawing.Point(117, 113);
            this.供應商代號TextBox.Name = "供應商代號TextBox";
            this.供應商代號TextBox.Size = new System.Drawing.Size(100, 25);
            this.供應商代號TextBox.TabIndex = 6;
            // 
            // 單位Label
            // 
            單位Label.AutoSize = true;
            單位Label.Location = new System.Drawing.Point(25, 147);
            單位Label.Name = "單位Label";
            單位Label.Size = new System.Drawing.Size(41, 15);
            單位Label.TabIndex = 7;
            單位Label.Text = "單位:";
            // 
            // 單位TextBox
            // 
            this.單位TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.庫存主檔BindingSource, "單位", true));
            this.單位TextBox.Location = new System.Drawing.Point(117, 144);
            this.單位TextBox.Name = "單位TextBox";
            this.單位TextBox.Size = new System.Drawing.Size(100, 25);
            this.單位TextBox.TabIndex = 8;
            // 
            // 規格Label
            // 
            規格Label.AutoSize = true;
            規格Label.Location = new System.Drawing.Point(25, 178);
            規格Label.Name = "規格Label";
            規格Label.Size = new System.Drawing.Size(41, 15);
            規格Label.TabIndex = 9;
            規格Label.Text = "規格:";
            // 
            // 規格TextBox
            // 
            this.規格TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.庫存主檔BindingSource, "規格", true));
            this.規格TextBox.Location = new System.Drawing.Point(117, 175);
            this.規格TextBox.Name = "規格TextBox";
            this.規格TextBox.Size = new System.Drawing.Size(100, 25);
            this.規格TextBox.TabIndex = 10;
            // 
            // 進價Label
            // 
            進價Label.AutoSize = true;
            進價Label.Location = new System.Drawing.Point(25, 209);
            進價Label.Name = "進價Label";
            進價Label.Size = new System.Drawing.Size(41, 15);
            進價Label.TabIndex = 11;
            進價Label.Text = "進價:";
            // 
            // 進價TextBox
            // 
            this.進價TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.庫存主檔BindingSource, "進價", true));
            this.進價TextBox.Location = new System.Drawing.Point(117, 206);
            this.進價TextBox.Name = "進價TextBox";
            this.進價TextBox.Size = new System.Drawing.Size(100, 25);
            this.進價TextBox.TabIndex = 12;
            // 
            // 售價Label
            // 
            售價Label.AutoSize = true;
            售價Label.Location = new System.Drawing.Point(25, 240);
            售價Label.Name = "售價Label";
            售價Label.Size = new System.Drawing.Size(41, 15);
            售價Label.TabIndex = 13;
            售價Label.Text = "售價:";
            // 
            // 售價TextBox
            // 
            this.售價TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.庫存主檔BindingSource, "售價", true));
            this.售價TextBox.Location = new System.Drawing.Point(117, 237);
            this.售價TextBox.Name = "售價TextBox";
            this.售價TextBox.Size = new System.Drawing.Size(100, 25);
            this.售價TextBox.TabIndex = 14;
            // 
            // 庫存量Label
            // 
            庫存量Label.AutoSize = true;
            庫存量Label.Location = new System.Drawing.Point(25, 271);
            庫存量Label.Name = "庫存量Label";
            庫存量Label.Size = new System.Drawing.Size(56, 15);
            庫存量Label.TabIndex = 15;
            庫存量Label.Text = "庫存量:";
            // 
            // 庫存量TextBox
            // 
            this.庫存量TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.庫存主檔BindingSource, "庫存量", true));
            this.庫存量TextBox.Location = new System.Drawing.Point(117, 268);
            this.庫存量TextBox.Name = "庫存量TextBox";
            this.庫存量TextBox.Size = new System.Drawing.Size(100, 25);
            this.庫存量TextBox.TabIndex = 16;
            // 
            // frmInvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 316);
            this.Controls.Add(品名代號Label);
            this.Controls.Add(this.品名代號TextBox);
            this.Controls.Add(品名Label);
            this.Controls.Add(this.品名TextBox);
            this.Controls.Add(供應商代號Label);
            this.Controls.Add(this.供應商代號TextBox);
            this.Controls.Add(單位Label);
            this.Controls.Add(this.單位TextBox);
            this.Controls.Add(規格Label);
            this.Controls.Add(this.規格TextBox);
            this.Controls.Add(進價Label);
            this.Controls.Add(this.進價TextBox);
            this.Controls.Add(售價Label);
            this.Controls.Add(this.售價TextBox);
            this.Controls.Add(庫存量Label);
            this.Controls.Add(this.庫存量TextBox);
            this.Controls.Add(this.庫存主檔BindingNavigator);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInvent";
            this.Text = "庫存資料管理表單";
            this.Load += new System.EventHandler(this.frmInvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.庫存主檔BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.庫存主檔BindingNavigator)).EndInit();
            this.庫存主檔BindingNavigator.ResumeLayout(false);
            this.庫存主檔BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetDB1 dataSetDB1;
        private System.Windows.Forms.BindingSource 庫存主檔BindingSource;
        private 進銷存管理系統.DataSetDB1TableAdapters.庫存主檔TableAdapter 庫存主檔TableAdapter;
        private 進銷存管理系統.DataSetDB1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator 庫存主檔BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton 庫存主檔BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox 品名代號TextBox;
        private System.Windows.Forms.TextBox 品名TextBox;
        private System.Windows.Forms.TextBox 供應商代號TextBox;
        private System.Windows.Forms.TextBox 單位TextBox;
        private System.Windows.Forms.TextBox 規格TextBox;
        private System.Windows.Forms.TextBox 進價TextBox;
        private System.Windows.Forms.TextBox 售價TextBox;
        private System.Windows.Forms.TextBox 庫存量TextBox;
    }
}