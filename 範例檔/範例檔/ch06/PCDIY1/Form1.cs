using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCDIY1
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

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= deskPC.GetUpperBound(0); i++)
            {
                lstdeskPC.Items.Add(deskPC[i] + "(" +
                     Convert.ToString(deskPCPrice[i]) + ")");
            }
            for (int i = 0; i <= CRT.GetUpperBound(0); i++)
            {
                cbxCRT.Items.Add(CRT[i] + "(" + Convert.ToString(CRTPrice[i]) + ")");
            }
            lstdeskPC.SelectedIndex = 0;
            // lstdeskPC.SetSelected(1,true);
            cbxCRT.SelectedIndex = 0;

            int sum = deskPCPrice[lstdeskPC.SelectedIndex] +
                    CRTPrice[cbxCRT.SelectedIndex];
            lblSum.Text = "合計：" + Convert.ToString(sum);
        }

        private void lstdeskPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int sum = deskPCPrice[lstdeskPC.SelectedIndex] +
                        CRTPrice[cbxCRT.SelectedIndex];
                lblSum.Text = "合計：" + Convert.ToString(sum);
            }
            catch { }
        }

        private void cbxCRT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int sum = deskPCPrice[lstdeskPC.SelectedIndex] +
                        CRTPrice[cbxCRT.SelectedIndex];
                lblSum.Text = "合計：" + Convert.ToString(sum);
            }
            catch { }
        }
    }
}
