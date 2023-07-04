using Newtonsoft.Json;
using System;
using System.Net.NetworkInformation;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using static HanteAPIPOS;
using System.Collections.Generic;

namespace HanteTcpDemo
{
    public partial class Main : Form
    {
        //配置数据
        string devicdId="";
        string ip = "";
        string token="";
        string merchantNo = "";

        HanteAPIPOS socketHelper;

        string localIp = "";

        public Main()
        {
            InitializeComponent();

            string sn = FileHelper.ReadFile("./config");
            if (null != sn && sn.Length > 0) {
                searchDevicePOS(sn);
            }

            //注意要：CMD配置防火墙
            //举例：
            //netsh http add urlacl url=http://192.168.6.102:4000/  user=Everyone
            //netsh advfirewall firewall Add rule name=\"Web访问4000\" dir=in protocol=tcp localport=4000 action=allow
            localIp = getIpAddress();

            config_notify_url_inp.Text = "http://" + localIp + ":4000/";
            Console.WriteLine("IP地址:" + localIp);

           // startWebServer()
            // 创建一个新的线程，并指定要执行的方法
            Thread thread = new Thread(startWebServer);
            // 启动线程
            thread.Start();


        }

        private void startWebServer() {

            var server = new HttpServer(localIp, 4000);
            server.Start();
        }

        private void chooseCheckOutTab(object sender, EventArgs e)
        {
           
            // 获取当前选中的选项卡索引
            int selectedIndex = tabControl.SelectedIndex;
            //MessageBox.Show(selectedIndex.ToString(), "提示框");
            // 根据选项卡索引执行相应操作
            switch (selectedIndex)
            {
                case 0://收银台
                    Console.WriteLine("选项卡1被选中");
                    // 执行选项卡1的操作
                    lab_ip.Text = ip;
                    lab_merchant_no.Text = merchantNo;
                    
                    break;
                case 1://配置页面
                  
                    string sn =FileHelper.ReadFile("./config");
                    Console.WriteLine("选项卡2被选中"+ sn);
                    device_sn_inp.Text = sn;
                    // 执行选项卡2的操作

                    break;
                default:
                    break;
            }

           
        }

        private void searchPOSDevice_Click(object sender, EventArgs e)
        {
            searchDevicePOS(device_sn_inp.Text);
            //存储SN
            FileHelper.WriteFile("./config", device_sn_inp.Text);
        }


        private void searchDevicePOS(string deviceSN) {

            // 获取TextBox的内容 device_sn_inp.Text
            string urlPath = "http://test.hantepay.cn/route/v2.0.0/machine/info?machineCode=" + deviceSN + "&type=short";
            string response = HttpUtils.SendGetRequest(urlPath);
           
            // 解析JSON字符串
            DeciveResponse deciveResponse = JsonConvert.DeserializeObject<DeciveResponse>(response);
            if (null != deciveResponse.Data)
            {
                string str = deciveResponse.Data.ConnectUrl;
                int indexStart = str.IndexOf(":");
                ip = str.Substring(0, indexStart);
                merchantNo = deciveResponse.Data.UserNo;
                //Confit Tab
                ip_inp.Text = ip;
                merchant_no_inp.Text = merchantNo;
                lab_config_device_status.Text = ip.Length > 0 ? "Success" : "Fail";
                //收银台Tab
                lab_ip.Text = ip;
                lab_merchant_no.Text = merchantNo;
 
            }
            else
            {
                lab_config_device_status.Text = deciveResponse.Return_msg;
            }
        }

        private void must_inp_num(object sender, KeyPressEventArgs e)
        {
            // 检查按键是否为数字或控制键
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // 阻止非数字键的输入
                e.Handled = true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
          
        }

        private void connectConfig_Click(object sender, EventArgs e)
        {
            LoadingDialogUtils.ShowLoadingDialog("Loading"); // 显示加载对话框

            socketHelper = new HanteAPIPOS();

            socketHelper.Connect(ip_inp.Text, 10010, ConnectedSuccess, ConnectedFail, POSHeartbeat, POSReceiveMessages);
        }


        public void ConnectedSuccess()
        {

            lab_config_connect_status.Text = "Success";
            lab_connect_status.Text = "Success";
            //查询token
            HantePOSMessage message = new HantePOSMessage();
            message.type = "searchToken";
            message.version = "V2";
            message.merchantNo = merchant_no_inp.Text;
            socketHelper.Send(JsonConvert.SerializeObject(message));
            // 休眠
            Thread.Sleep(200);

            HantePOSMessage messageSign = new HantePOSMessage();
            messageSign.type = "searchCreditCardSignInStatus";
            messageSign.version = "V2";
            messageSign.merchantNo = merchant_no_inp.Text;
            socketHelper.Send(JsonConvert.SerializeObject(messageSign));

        }



        public void ConnectedFail(string msg)
        {
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
                   
                    LoadingDialogUtils.HideLoadingDialog(); // 隐藏加载对话框

                    if ("searchCreditCardSignInStatus".Equals(deciveResponse.type))
                    {
                        lab_config_sign_status.Text = "Fail";
                    }
                    else if ("transaction".Equals(deciveResponse.type) || "refund".Equals(deciveResponse.type))
                    {
                        responseTv.Text = deciveResponse.resultMsg;

                    }
                    else {
                        responseTv.Text = "";
                    }

                };
                Invoke(action);

            }
            else
            {
                //MessageBox.Show(deciveResponse.resultCode, "transaction");

                Action action = () =>
                {
                   

                    if ("searchToken".Equals(deciveResponse.type))
                    {
                        //解析Token 数据
                        if (deciveResponse.tokenList.Count > 0)
                        {
                            devicdId = deciveResponse.tokenList[0].deviceId;
                            token = deciveResponse.tokenList[0].token;
                            lab_config_pair_status.Text = "Success";
                        }
                        else {
                            lab_config_pair_status.Text = "Fail";
                        }
                    } else if ("devicePair".Equals(deciveResponse.type)) {
                        if (null!=deciveResponse.token)
                        {
                            devicdId = deciveResponse.token.deviceId;
                            token = deciveResponse.token.token;
                            lab_config_pair_status.Text = "Success";
                        }
                        else
                        {
                            lab_config_pair_status.Text = "Fail";
                        }
                    }
                    else if ("reSetPair".Equals(deciveResponse.type))
                    {
                        lab_config_pair_status.Text = "Fail";
                    }
                    else if ("searchCreditCardSignInStatus".Equals(deciveResponse.type))
                    {
                        lab_config_sign_status.Text = "Success";
                    }
                    else if ("transaction".Equals(deciveResponse.type))
                    {
                        responseTv.Text = deciveResponse.paymentMethod +" Payment "+ deciveResponse.resultCode;

                    }
                    else if ("refund".Equals(deciveResponse.type))
                    {
                        responseTv.Text = "Refund " + deciveResponse.resultCode;

                    }
                    else if ("paymentNotifyUrl".Equals(deciveResponse.type))
                    {
                        config_notify_url_status.Text = "Success";
                        //MessageBox.Show(, "提示");
                    }else if ("orderQuery".Equals(deciveResponse.type))
                    {
                        payment_amount_tv.Text = "$" + (int.Parse(deciveResponse.totalAmount) * 0.01).ToString();
                        responseTv.Text = deciveResponse.paymentMethod;//msg;
                    }

                    LoadingDialogUtils.HideLoadingDialog(); // 隐藏加载对话框
                };
                Invoke(action);


            }

        }

        private void disconnectPOS_Click(object sender, EventArgs e)
        {
            socketHelper.Disconnect();
            lab_config_connect_status.Text = "Fail";
            lab_connect_status.Text = "Fail";
        }

        private void pairPOS_Click(object sender, EventArgs e)
        {
            if (null == socketHelper)
            {
                MessageBox.Show("请连接POS", "提示");
                return;
            }

            //POS pair
            HantePOSMessage message = new HantePOSMessage();
            message.type = "devicePair";
            message.version = "V2";
            message.merchantNo = merchant_no_inp.Text;
            message.verifyCode = verify_code_inp.Text;
            socketHelper.Send(JsonConvert.SerializeObject(message));
        }

        private void signinPOS_Click(object sender, EventArgs e)
        {
            if (null == socketHelper)
            {
                MessageBox.Show("请连接POS", "提示");
                return;
            }

            LoadingDialogUtils.ShowLoadingDialog("Loading"); // 显示加载对话框
            //POS pair
            HantePOSMessage message = new HantePOSMessage();
            message.type = "creditCardSignIn";
            message.version = "V2";
            message.deviceId = devicdId;
            message.merchantNo = merchant_no_inp.Text;
            message.password = tsys_password_inp.Text;
            message.MD5Encrypt16(token);
            socketHelper.Send(JsonConvert.SerializeObject(message));
        }

        private void salePOS_Click(object sender, EventArgs e)
        {
            payment("POS_PAYMENT", "SALE");//刷卡
        }


        private void authPOS_Click(object sender, EventArgs e)
        {
            payment("POS_PAYMENT", "AUTH");//刷卡
        }

        private void scanCodePayment_Click(object sender, EventArgs e)
        {
            payment("SCAN_CODE_PAYMENT", "");

        }

        private void qrCodePayment_Click(object sender, EventArgs e)
        {
            //二维码收款
            payment("QR_CODE_PAYMENT", "");
        }

        private void payment(string paymentType, string transType)
        {

            if (null == socketHelper)
            {
                MessageBox.Show("请连接POS", "提示框");
                return;
            }

            LoadingDialogUtils.ShowLoadingDialog("Loading"); // 显示加载对话框
            // sale
            HantePOSMessage message = new HantePOSMessage();
            int totalAmount = 0;
            message.type = "transaction";//交易

            message.paymentScenario = paymentType;

            if (null != transType && transType.Length > 0)
            {
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
            message.merchantNo = merchantNo;
            message.deviceId = devicdId;
            message.currency = "USD";//货币默认USD 
            message.desc = "测试";//备注

            DateTime epochStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan timeSpan = DateTime.UtcNow - epochStart;

            payment_amount_tv.Text = "$" + (totalAmount * 0.01);

            order_no_inp.Text = ((long)timeSpan.TotalMilliseconds).ToString();
            message.orderNo = order_no_inp.Text;
            message.MD5Encrypt16(token);
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
            message.deviceId = devicdId;
            message.orderNo = order_no_inp.Text;
            message.MD5Encrypt16(token);
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
            message.merchantNo = merchantNo;
            message.deviceId = devicdId;
            message.transactionId = hante_trans_id.Text;
            message.MD5Encrypt16(token);
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
            message.merchantNo = merchantNo;
            message.deviceId = devicdId;
            message.transactionId = hante_trans_id.Text;
            message.amount = refund_amount_inp.Text;
            message.MD5Encrypt16(token);
            //计算signature
            socketHelper.Send(JsonConvert.SerializeObject(message));

        }

        private void reSetPair_Click(object sender, EventArgs e)
        {
            if (null == socketHelper)
            {
                MessageBox.Show("请连接POS", "提示框");
                return;
            }

            LoadingDialogUtils.ShowLoadingDialog("Loading"); // 显示加载对话框
            //退款
            HantePOSMessage message = new HantePOSMessage();
            message.type = "reSetPair";
            message.version = "V2";
            message.merchantNo = merchantNo;
            message.deviceId = devicdId;
            message.MD5Encrypt16(token);
            //计算signature
            socketHelper.Send(JsonConvert.SerializeObject(message));
        }

        private void setPOSNotifyUrl_Click(object sender, EventArgs e)
        {

            if (null == socketHelper)
            {
                MessageBox.Show("请连接POS", "提示框");
                return;
            }

            LoadingDialogUtils.ShowLoadingDialog("Loading"); // 显示加载对话框
            //退款
            HantePOSMessage message = new HantePOSMessage();
            message.type = "paymentNotifyUrl";
            message.version = "V2";
            message.merchantNo = merchantNo;
            message.deviceId = devicdId;
            message.notifyUrl = config_notify_url_inp.Text;
            message.MD5Encrypt16(token);
            //计算signature
            socketHelper.Send(JsonConvert.SerializeObject(message));
        }



        private string getIpAddress() {
            // 获取所有网络接口
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in interfaces)
            {
                // 排除回环接口和非活动接口
                if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Loopback || networkInterface.OperationalStatus != OperationalStatus.Up)
                    continue;


                // 获取网络接口的 IP 属性集合
                IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();

                foreach (UnicastIPAddressInformation ipAddressInfo in ipProperties.UnicastAddresses)
                {
                    // 过滤 IPv4 地址和本地链接地址
                    if (ipAddressInfo.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork &&
                        !IPAddress.IsLoopback(ipAddressInfo.Address))
                    {
                        return ipAddressInfo.Address.ToString();
                       
                    }
                }
            }

            return "";
        }


    }
}
