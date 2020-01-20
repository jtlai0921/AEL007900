using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[] btn = new Button[10];  // 建立btn為控制項陣列裡面存放按鈕控制項
        int[] b = new int[10];           // 記錄哪個按鈕是誰按的 1:先玩者 , -1:表後玩者
        int flag = 1;                   // flag=1表輪到先玩者下 , flag= 0 表輪到後玩者下
        int count;                    // 記錄目前有多少個按鈕已經被按

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMsg.Font = new Font("新細明體", 16, FontStyle.Bold);
            lblMsg.Text = "起手無回大丈夫";    // 顯示抬頭訊息
            btn[1] = button1; btn[2] = button2; btn[3] = button3;   // 將控制項指到對應的陣列
            btn[4] = button4; btn[5] = button5; btn[6] = button6;
            btn[7] = button7; btn[8] = button8; btn[9] = button9;

            for (int i = 1; i <= btn.GetUpperBound(0); i++)
            {
                btn[i].Enabled = false;     // 九個按鈕設成失效
                btn[i].Text = "";
                btn[i].Tag = i;
                // 讓九個按鈕的Click事件被觸發時，皆可執行btnEvent事件處理函式
                btn[i].Click += new EventHandler(btnEvent);
            }
        }

        // 讓九個按鈕設成失效
        void ButtonFail()     //  自訂方法
        {
            for (int i = 1; i <= btn.GetUpperBound(0); i++)
            {
                btn[i].Enabled = false;     // 九個按鈕設成失效
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            count = 0;
            btnStart.Text = "重玩";
            for (int i = 1; i <= btn.GetUpperBound(0); i++)
            {
                btn[i].Enabled = true;           // 按鈕設為無效
                btn[i].Text = "";                // 清除按鈕上面文字
                btn[i].BackColor = Color.White;  // 按鈕恢復成白色
                b[i] = 0;                       // 將存放哪方按鈕的值清為0
                flag = 1;                       // 還原為1表下次先下者為藍底
            }
        }

        private void btnEvent(object sender, EventArgs e)
        {
            Button btnHit;             // 宣告btnHit按鈕物件
            btnHit = (Button)sender;    // 將按鈕被按下的Name屬性指定給btnHit
            // 將目前被按下按鈕上面的字型設成新細明體、粗體大小為16
            btnHit.Font = new Font("Arial", 16, FontStyle.Bold);

            if (flag == 1)    // 先下者
            {
                btnHit.BackColor = Color.Cyan; // 將目前被按下的按鈕設成藍底
                btnHit.Text = "1";             // 將目前被按下的按鈕顯示1
                btnHit.Enabled = false;         // 將目前被按下的按鈕設成失效
                b[Convert.ToInt32(btnHit.Tag)] = 1;  // 將目前被按按鈕的Tag 當陣列b註標存入1
                flag = 0;                      // 換另一方按鈕
            }
            else   // 後下者
            {
                btnHit.BackColor = Color.Yellow;  // 將目前被按下的按鈕設成黃底
                btnHit.Text = "0";                // 將目前被按下的按鈕顯示0
                btnHit.Enabled = false;  //  將目前被按下的按鈕設成失效
                b[Convert.ToInt32(btnHit.Tag)] = -1;  // 將目前被按按鈕的Tag當陣列b註標存入-1
                flag = 1;     // 換另一方按鈕
            }

            int sum1, sum2, sum3, sum4, sum5, sum6, sum7, sum8;
            sum1 = b[1] + b[2] + b[3]; sum2 = b[4] + b[5] + b[6];
            sum3 = b[7] + b[8] + b[9]; sum4 = b[1] + b[4] + b[7];
            sum5 = b[2] + b[5] + b[8]; sum6 = b[3] + b[6] + b[9];
            sum7 = b[1] + b[5] + b[9]; sum8 = b[3] + b[5] + b[7];
            count++;
            // 判斷是否藍色贏
            if (sum1 == 3 || sum2 == 3 || sum3 == 3 || sum4 == 3 || sum5 == 3 || sum6 == 3 ||
                sum7 == 3 || sum8 == 3)
            {
                ButtonFail();
                MessageBox.Show("  藍色贏　Blue Win !! ...");
                return;
            }
            // 判斷是否黃色贏
            if (sum1 == -3 || sum2 == -3 || sum3 == -3 || sum4 == -3 || sum5 == -3 || sum6 == -3 ||
                sum7 == -3 || sum8 == -3)
            {
                ButtonFail();
                MessageBox.Show("  黃色贏　Ｙellow Win !! ...");
                return;
            }
            if (count == 9)
            {
                MessageBox.Show("  雙方平手 !! ...");
                return;
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

