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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void 客戶資料管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 建立子表單的新執行個體。
            frmCust ChildForm = new frmCust();
            // 將它變成這個 MDI 表單的子表單，然後才顯示。
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void 客戶資料查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustSel ChildForm = new frmCustSel();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void 供應商資料管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendor ChildForm = new frmVendor();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void 供應商資料查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendorSel ChildForm = new frmVendorSel();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void 庫存資料管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvent ChildForm = new frmInvent();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void 庫存資料查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventSel ChildForm = new frmInventSel();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void 進貨處理作業ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuy ChildForm = new frmBuy();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void 進貨查詢作業ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuySel ChildForm = new frmBuySel();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void 進退處理作業ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuyRet ChildForm = new frmBuyRet();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void 進退查詢作業ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuyRetSel ChildForm = new frmBuyRetSel();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void 銷貨處理作業ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSale ChildForm = new frmSale();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void 銷貨查詢作業ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleSel ChildForm = new frmSaleSel();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void 銷退處理作業ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleRet ChildForm = new frmSaleRet();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void 銷退查詢作業ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleRetSel ChildForm = new frmSaleRetSel();
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }
    }
}
