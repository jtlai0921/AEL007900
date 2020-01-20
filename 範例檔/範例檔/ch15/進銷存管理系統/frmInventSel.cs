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
    public partial class frmInventSel : Form
    {
        public frmInventSel()
        {
            InitializeComponent();
        }

        private void frmInventSel_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'dataSetDB1.庫存主檔' 資料表。
            //您可以視需要進行移動或移除。
            this.庫存主檔TableAdapter.Fill(this.dataSetDB1.庫存主檔);
            //使 庫存主檔DataGridView填滿整個表單
            this.庫存主檔DataGridView.Dock = DockStyle.Fill;
        }
    }
}
