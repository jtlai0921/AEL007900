using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data .OleDb ; //引用System.Data.OleDb命名空間

namespace 進銷存管理系統
{
    public partial class frmSaleRet : Form
    {
        public frmSaleRet()
        {
            InitializeComponent();
        }

        private void frmSaleRet_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'dataSetDB1.庫存主檔' 
            //資料表。您可以視需要進行移動或移除。
            this.庫存主檔TableAdapter.Fill(this.dataSetDB1.庫存主檔);
            // TODO: 這行程式碼會將資料載入 'dataSetDB1.客戶' 
            //資料表。您可以視需要進行移動或移除。
            this.客戶TableAdapter.Fill(this.dataSetDB1.客戶);
            //銷退日期lblToday顯示今天日期
            lblToday.Text = DateTime.Now.ToShortDateString();
            txtQty.Text = "0";   //銷退數量預設為0
        }

        //按下新增銷退btnAddSaleRet鈕時會執行btnAddSaleRet_Click事件處理函式
        private void btnAddSaleRet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定是否進行銷貨退回?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //連接db1.mdb資料庫
                OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db1.mdb");
                cn.Open();
                OleDbCommand cmd = new OleDbCommand(); //建立OleDbCommand的cmd物件
                cmd.Connection = cn;   //cmd物件連接db1.mdb
                //建立SQL INSERT敘述，該敘述可將銷退資料寫入'銷退明細'資料表
                cmd.CommandText = "INSERT INTO 銷退明細(客戶代號,品名代號" +
                 ",售價,數量,備註,銷退日期)VALUES('" +
                cboCustName.SelectedValue + "','" +
                cboProductName.SelectedValue + "'," +
                Convert.ToInt32(txtSalePrice.Text) + "," +
                Convert.ToInt32(txtQty.Text) + ",'" +
                txtNote.Text + "','" +
                lblToday.Text + "')";
                cmd.ExecuteNonQuery(); //執行SQL敘述，進行銷退處理
                //建立SQL UPDATE敘述，該敘述用來修改庫存主檔指定品名代號的庫存量
                cmd.CommandText = "UPDATE 庫存主檔 SET 庫存量=庫存量+" + Convert.ToInt32(txtQty.Text) + " WHERE 品名代號='" + cboProductName.SelectedValue.ToString() + "'";
                cmd.ExecuteNonQuery();   //執行SQL敘述，更新庫存量
                MessageBox.Show("銷貨退回成功!");
                txtQty.Text = "0";
                txtNote.Text = "";
            }
        }
    }
}
