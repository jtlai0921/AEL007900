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
    public partial class frmSaleSel : Form
    {
        public frmSaleSel()
        {
            InitializeComponent();
        }

        private void frmSaleSel_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'dataSetDB1.銷貨明細查詢' 
            // 資料表。您可以視需要進行移動或移除。
            this.銷貨明細查詢TableAdapter.Fill(this.dataSetDB1.銷貨明細查詢);
            this.銷貨明細查詢DataGridView.Dock = DockStyle.Fill;
        }
    }
}
