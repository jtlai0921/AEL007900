using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCDIV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] deskPC = new string[] { "華爍主機", "碁峰主機", "技佳主機", "津英主機" };
        int[] deskPCPrice = new int[] { 20000, 18000, 15000, 12000 };
        string[] CRT = new string[] { "15吋", "17吋", "19吋" };
        int[] CRTPrice = new int[] { 4000, 5000, 6000 };
        string[] device = new string[] { "滑鼠", "鍵盤", "1G隨身碟", "DVD燒錄器" };
        int[] devicePrice = new int[] { 300, 400, 500, 800 };

        int deviceSum = 0;   // 存放勾選配件的合計金額

        private void Form1_Load(object sender, EventArgs e)
        {
            // 設定主機清單初值 
            for (int i = 0; i <= deskPC.GetUpperBound(0); i++)
            {
                lstdeskPC.Items.Add(deskPC[i] + "(" + Convert.ToString(deskPCPrice[i]) + ")");
            }
            // 設定螢幕下拉式清單初值
            for (int i = 0; i <= CRT.GetUpperBound(0); i++)
            {
                cbxCRT.Items.Add(CRT[i] + "(" + Convert.ToString(CRTPrice[i]) + ")");
            }
            // 設定 週邊配件核取清單初值
            for (int i = 0; i <= device.GetUpperBound(0); i++)
            {
                cblDevice.Items.Add(device[i] + "(" + Convert.ToString(devicePrice[i]) + ")");
            }
            // 設定各清單最開頭項目為預選項目
            cbxCRT.SelectedIndex = 0;
            lstdeskPC.SelectedIndex = 0;
            cblDevice.SelectedIndex = 0;
            // 將核取清單第一個項目預設為勾選
            cblDevice.SetItemChecked(0, true);
            // 將核取清單按一次即選取
            cblDevice.CheckOnClick = true;
            // 顯示預選項目的合計金額
            int sum = deskPCPrice[lstdeskPC.SelectedIndex] +
                CRTPrice[cbxCRT.SelectedIndex] + devicePrice[cblDevice.SelectedIndex];
            lblSum.Text = "合計：" + Convert.ToString(sum);
        }

        private void lstdeskPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int sum = deskPCPrice[lstdeskPC.SelectedIndex] +
                    CRTPrice[cbxCRT.SelectedIndex] + deviceSum;
                lblSum.Text = "合計：" + Convert.ToString(sum);
            }
            catch { }
        }

        private void cbxCRT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int sum = deskPCPrice[lstdeskPC.SelectedIndex] +
                    CRTPrice[cbxCRT.SelectedIndex] + deviceSum;
                lblSum.Text = "合計：" + Convert.ToString(sum);
            }
            catch { }

        }

        private void cblDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                deviceSum = 0;  // 存放被勾選項目的總金額                
                for (int i = 0; i < 4; i++)  // 將有被勾選項的單價加總至devicSum變數
                {
                    if (cblDevice.GetItemChecked(i) == true)
                        deviceSum += devicePrice[i];
                }
                int sum = deskPCPrice[lstdeskPC.SelectedIndex] +
                    CRTPrice[cbxCRT.SelectedIndex] + deviceSum;
                lblSum.Text = "合計：" + Convert.ToString(sum);
            }
            catch { }
        }
    }
}
