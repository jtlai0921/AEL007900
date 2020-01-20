using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;//引用System.Data.OleDb命名空間

namespace 進銷存管理系統
{
    public partial class frmBuyRet : Form
    {
        public frmBuyRet()
        {
            InitializeComponent();
        }

        //frmBuyRet表單載入時執行frmBuyRet_Load事件處理函式
        private void frmBuyRet_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'dataSetDB1.庫存主檔' 資料表。
            //您可以視需要進行移動或移除。
            this.庫存主檔TableAdapter.Fill(this.dataSetDB1.庫存主檔);
            // TODO: 這行程式碼會將資料載入 'dataSetDB1.供應商' 資料表。
            //您可以視需要進行移動或移除。
            this.供應商TableAdapter.Fill(this.dataSetDB1.供應商);
            // 庫存主檔BindingSource搜尋供應商代號等於
            //cboVendorName.SelectedValue
            this.庫存主檔BindingSource.Filter = "供應商代號='" + cboVendorName.SelectedValue.ToString() + "'";
            //進退日期lblToday顯示今天日期
            lblToday.Text = DateTime.Now.ToShortDateString();
            txtQty.Text = "0";   //進退數量預設為0
        }

        //當供應商名稱cboVendorName清單被選取之後，會執行
        //cboVendorName_SelectedIndexChanged事件處理函式
        private void cboVendorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 庫存主檔BindingSource搜尋供應商代號等於
            //cboVendorName.SelectedValue的資料
            // 使cboProductName清單能顯示該供應商所銷售的產品
            try
            {
                this.庫存主檔BindingSource.Filter = "供應商代號='" + cboVendorName.SelectedValue.ToString() + "'";
            }
            catch { }
        }
        //'按下新增進退btnAddBuyRet鈕時會執行btnAddBuyRet_Click事件處理函式
        private void btnAddBuyRet_Click(object sender, EventArgs e)
        {
            // 出現對話方塊，詢問確定是否進行退貨退回?
            if (MessageBox.Show("確定是否進行進貨退回?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //連接db1.mdb資料庫
                OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db1.mdb");
                cn.Open();
                //建立OleDbCommand的cmd物件
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn; //cmd物件連接db1.mdb
                //建立SQL INSERT敘述，該敘述可將進退資料寫入'進退明細'資料表
                cmd.CommandText = "INSERT INTO 進退明細(供應商代號," +
                "品名代號,進價,數量,備註,進退日期)VALUES('" +
                cboVendorName.SelectedValue + "','" +
                cboProductName.SelectedValue + "'," +
                Convert.ToInt32(txtBuyPrice.Text) + "," +
                Convert.ToInt32(txtQty.Text) + ",'" +
                txtNote.Text + "','" +
                lblToday.Text + "')";
                cmd.ExecuteNonQuery();  //執行SQL敘述，進行進貨退回
                //建立SQL UPDATE敘述，該敘述用來修改庫存主檔指定品名代號的庫存量
                cmd.CommandText = "UPDATE 庫存主檔 SET 庫存量=庫存量-" + Convert.ToInt32(txtQty.Text) + " WHERE 品名代號='" + cboProductName.SelectedValue.ToString() + "'";
                cmd.ExecuteNonQuery();  //執行SQL敘述，更新庫存量
                MessageBox.Show("進貨退回成功!");
                txtQty.Text = "0";
                txtNote.Text = "";
            }
        }
    }
}
