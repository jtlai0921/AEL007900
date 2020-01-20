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
    public partial class frmVendorSel : Form
    {
        public frmVendorSel()
        {
            InitializeComponent();
        }

        private void frmVendorSel_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'dataSetDB1.供應商' 資料表。
            //您可以視需要進行移動或移除。
            this.供應商TableAdapter.Fill(this.dataSetDB1.供應商);
            //使供應商DataGridView填滿整個表單
            this.供應商DataGridView.Dock = DockStyle.Fill;
        }
    }
}
