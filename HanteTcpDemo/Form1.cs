using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace HanteTcpDemo
{
    public partial class Form1 : Form
    {
        SocketClient socketHelper;

        public Form1()
        {
            InitializeComponent();
            // 将按钮的点击事件与事件处理程序关联
           // searchDevice.Click += searchDevice_Click;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchDevice_Click(object sender, EventArgs e)
        {
            // 获取TextBox的内容 device_sn_inp.Text
            string urlPath = "http://test.hantepay.cn/route/v2.0.0/machine/info?machineCode="+device_sn_inp.Text+ "&type=short";  
            string response = HantePOSAPI.SendGetRequest(urlPath);
            responseTv.Text = response;
            // 解析JSON字符串
            DeciveResponse deciveResponse = JsonConvert.DeserializeObject<DeciveResponse>(response);
            string str = deciveResponse.Data.ConnectUrl;
            int indexStart = str.IndexOf(":");
            ip_inp.Text = str.Substring(0, indexStart);
            merchant_no_inp.Text= deciveResponse.Data.UserNo;
           
        }

        private void connectPOS_Click(object sender, EventArgs e)
        {

            LoadingDialogUtils.ShowLoadingDialog("Loading"); // 显示加载对话框

            socketHelper = new SocketClient();

            socketHelper.Connect(ip_inp.Text, 10010, ConnectedSuccess, ConnectedFail, POSHeartbeat, POSReceiveMessages);
       

        }


        private void pairPOS_Click(object sender, EventArgs e)
        {
            //POS pair
            HantePOSMessage message = new HantePOSMessage();
            message.type = "devicePair";
            message.version = "V2";
            message.merchantNo = merchant_no_inp.Text;
            message.verifyCode= verify_code_inp.Text;
            socketHelper.Send(JsonConvert.SerializeObject(message));
        }


        private void signinPOS_Click(object sender, EventArgs e)
        {
            LoadingDialogUtils.ShowLoadingDialog("Loading"); // 显示加载对话框
            //POS pair
            HantePOSMessage message = new HantePOSMessage();
            message.type = "creditCardSignIn";
            message.version = "V2";
            message.deviceId = device_id_inp.Text;
            message.merchantNo = merchant_no_inp.Text;
            message.password = tsys_password_inp.Text;
            message.MD5Encrypt16(token_inp.Text);
            socketHelper.Send(JsonConvert.SerializeObject(message));
        }


        private void disconnect_Click(object sender, EventArgs e)
        {
            socketHelper.Disconnect();
            content_status.Text = "Disconnect";
        }

        private void sale_Click(object sender, EventArgs e)
        {
            payment("POS_PAYMENT", "SALE");//刷卡

        }

        private void authPOS_Click(object sender, EventArgs e)
        {
            payment("POS_PAYMENT", "AUTH");//刷卡
           
        }


        private void scanCodePayment_Click(object sender, EventArgs e)
        {
            payment("SCAN_CODE_PAYMENT","");
           
        }


        private void qrCodePayment_Click(object sender, EventArgs e)
        {
            //二维码收款
            payment("QR_CODE_PAYMENT","");
        }

        private void payment(string paymentType,string transType) {

            if (null == socketHelper) {
                MessageBox.Show("请连接POS", "提示框");
                return;
            }

            LoadingDialogUtils.ShowLoadingDialog("Loading"); // 显示加载对话框
            // sale
            HantePOSMessage message = new HantePOSMessage();
            int totalAmount = 0;
            message.type = "transaction";//交易

            message.paymentScenario =  paymentType;
       
            if (null != transType && transType.Length > 0) {
                message.transType = transType;
            }
            if (null != amount_inp.Text && amount_inp.Text.Length > 0)
            {
                message.amount = amount_inp.Text;//消费金额

                totalAmount += int.Parse(amount_inp.Text);
            }

            //判断是否有小费 注意：预授权没有小费
            if (null != tip_amount_inp.Text && tip_amount_inp.Text.Length > 0 && !"AUTH".Equals(transType))
            {
                message.additionalCharges = "{\"taxAmount\":0,\"tipCustom\":false,\"tipAmount\":" + tip_amount_inp.Text + "}";//附加费

                totalAmount += int.Parse(tip_amount_inp.Text);
            }
            message.version = "V2";
            message.merchantNo = merchant_no_inp.Text;
            message.deviceId = device_id_inp.Text;
            message.currency = "USD";//货币默认USD 
            message.desc = "测试";//备注

            DateTime epochStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan timeSpan = DateTime.UtcNow - epochStart;

            payment_amount_tv.Text = "$" + (totalAmount * 0.01);

            order_no_inp.Text = ((long)timeSpan.TotalMilliseconds).ToString();
            message.orderNo = order_no_inp.Text;
            message.MD5Encrypt16(token_inp.Text);
            //计算signature
            socketHelper.Send(JsonConvert.SerializeObject(message));
        }

        private void cancelPaymentPOS_Click(object sender, EventArgs e)
        {
            if (null == socketHelper)
            {
                MessageBox.Show("请连接POS", "提示框");
                return;
            }

            LoadingDialogUtils.ShowLoadingDialog("Loading"); // 显示加载对话框
            //取消收款
            HantePOSMessage message = new HantePOSMessage();
            message.type = "transactionCancel";
            message.version = "V2";
            message.merchantNo = merchant_no_inp.Text;
            message.deviceId = device_id_inp.Text;
            message.orderNo = order_no_inp.Text;
            message.MD5Encrypt16(token_inp.Text);
            //计算signature
            socketHelper.Send(JsonConvert.SerializeObject(message));

        }

        private void searchPOSOrder_Click(object sender, EventArgs e)
        {
            if (null == socketHelper)
            {
                MessageBox.Show("请连接POS", "提示框");
                return;
            }

            LoadingDialogUtils.ShowLoadingDialog("Loading"); // 显示加载对话框
            //查询订单
            HantePOSMessage message = new HantePOSMessage();
            message.type = "orderQuery";
            message.version = "V2";
            message.merchantNo = merchant_no_inp.Text;
            message.deviceId = device_id_inp.Text;
            message.transactionId = hante_trans_id.Text;
            message.MD5Encrypt16(token_inp.Text);
            //计算signature
            socketHelper.Send(JsonConvert.SerializeObject(message));
        }


        private void refundPOS_Click(object sender, EventArgs e)
        {
            if (null == socketHelper)
            {
                MessageBox.Show("请连接POS", "提示框");
                return;
            }

            LoadingDialogUtils.ShowLoadingDialog("Loading"); // 显示加载对话框
            //退款
            HantePOSMessage message = new HantePOSMessage();
            message.type = "refund";
            message.version = "V2";
            message.merchantNo = merchant_no_inp.Text;
            message.deviceId = device_id_inp.Text;
            message.transactionId = hante_trans_id.Text;
            message.amount = refund_amount_inp.Text;
            message.MD5Encrypt16(token_inp.Text);
            //计算signature
            socketHelper.Send(JsonConvert.SerializeObject(message));

        }


        private void button4_Click(object sender, EventArgs e)
        {

        }


        public void ConnectedSuccess() {
         
            content_status.Text = "Connected Success";
             //查询token
            HantePOSMessage message = new HantePOSMessage();
            message.type = "searchToken";
            message.version = "V2";
            message.merchantNo = merchant_no_inp.Text;
            socketHelper.Send(JsonConvert.SerializeObject(message));
        }



        public void ConnectedFail(string msg) {
            MessageBox.Show(msg, "提示框");
          
        }

        public void POSHeartbeat()
        {
          
        }

        public void POSReceiveMessages(string msg)
        {

            // MessageBox.Show(msg, "POSReceiveMessages");
   
            //解析JSON 数据
            HantePOSMessage deciveResponse = JsonConvert.DeserializeObject<HantePOSMessage>(msg);
            if (!"SUCCESS".Equals(deciveResponse.resultCode))
            {
              //  MessageBox.Show(deciveResponse.resultMsg, "transaction");

                Action action = () =>
                {
                    responseTv.Text = deciveResponse.resultMsg;
                    LoadingDialogUtils.HideLoadingDialog(); // 隐藏加载对话框
                };
                Invoke(action);

            }
            else {
                //MessageBox.Show(deciveResponse.resultCode, "transaction");

                Action action = () =>
                {
                    responseTv.Text = deciveResponse.resultCode;

                    if ("searchToken".Equals(deciveResponse.type))
                    {
                        //解析Token 数据
                        if (deciveResponse.tokenList.Count > 0)
                        {
                                device_id_inp.Text = deciveResponse.tokenList[0].deviceId;
                                token_inp.Text = deciveResponse.tokenList[0].token;
                        }
                    }
                    else if ("transaction".Equals(deciveResponse.type))
                    {


                    }
                    else if ("orderQuery".Equals(deciveResponse.type))
                    {
                        payment_amount_tv.Text ="$"+(int.Parse(deciveResponse.totalAmount) * 0.01).ToString();
                            responseTv.Text = msg;
                    }

                    LoadingDialogUtils.HideLoadingDialog(); // 隐藏加载对话框
                };
                Invoke(action);

              
            }

        }

        private void input_must_num(object sender, KeyPressEventArgs e)
        {
            // 检查按键是否为数字或控制键
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // 阻止非数字键的输入
                e.Handled = true;
            }
        }


    }
}
