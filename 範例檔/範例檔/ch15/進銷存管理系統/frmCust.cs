using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 進銷存管理系統
{
    public partial class frmCust : Form
    {
        public frmCust()
        {
            InitializeComponent();
        }

        private void 客戶BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.客戶BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetDB1);
        }

        private void frmCust_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'dataSetDB1.客戶' 資料表。您可以視需要進行移動或移除。
            this.客戶TableAdapter.Fill(this.dataSetDB1.客戶);
        }
    }
}
