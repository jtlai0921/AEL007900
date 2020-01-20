using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RelationDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'dataSetDB1.進貨明細' 資料表。您可以視需要進行移動或移除。
            this.進貨明細TableAdapter.Fill(this.dataSetDB1.進貨明細);
            // TODO: 這行程式碼會將資料載入 'dataSetDB1.供應商' 資料表。您可以視需要進行移動或移除。
            this.供應商TableAdapter.Fill(this.dataSetDB1.供應商);
            // 供應商DataGridView停駐表單上方
            this.供應商DataGridView.Dock = DockStyle.Top;
            // 進貨明細DataGridView填滿整個表單
            this.進貨明細DataGridView.Dock = DockStyle.Fill;
            // 依進貨日期做遞減排序
            this.進貨明細BindingSource.Sort = "進貨日期 DESC";
        }

        private void 供應商BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.供應商BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetDB1);
        }
    }
}
