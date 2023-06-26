namespace HanteTcpDemo
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_check_out = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.refund_btn = new System.Windows.Forms.Button();
            this.refund_amount_inp = new System.Windows.Forms.TextBox();
            this.search_order_btn = new System.Windows.Forms.Button();
            this.hante_trans_id = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lab_connect_status = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lab_merchant_no = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab_ip = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.responseTv = new System.Windows.Forms.Label();
            this.payment_amount_tv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.order_no_inp = new System.Windows.Forms.TextBox();
            this.cancel_payment_btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sale_btn = new System.Windows.Forms.Button();
            this.tip_amount_inp = new System.Windows.Forms.TextBox();
            this.amount_inp = new System.Windows.Forms.TextBox();
            this.disconnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tab_config = new System.Windows.Forms.TabPage();
            this.config_notify_url_status = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.config_notify_url_inp = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.lab_config_sign_status = new System.Windows.Forms.Label();
            this.lab_config_pair_status = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lab_config_device_status = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lab_config_connect_status = new System.Windows.Forms.Label();
            this.tsys_signin_btn = new System.Windows.Forms.Button();
            this.tsys_password_inp = new System.Windows.Forms.TextBox();
            this.pair_btn = new System.Windows.Forms.Button();
            this.verify_code_inp = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.merchant_no_inp = new System.Windows.Forms.TextBox();
            this.ip_inp = new System.Windows.Forms.TextBox();
            this.searchDevice = new System.Windows.Forms.Button();
            this.device_sn_inp = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tab_check_out.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_config.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_check_out);
            this.tabControl.Controls.Add(this.tab_config);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(913, 536);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.chooseCheckOutTab);
            // 
            // tab_check_out
            // 
            this.tab_check_out.Controls.Add(this.label4);
            this.tab_check_out.Controls.Add(this.refund_btn);
            this.tab_check_out.Controls.Add(this.refund_amount_inp);
            this.tab_check_out.Controls.Add(this.search_order_btn);
            this.tab_check_out.Controls.Add(this.hante_trans_id);
            this.tab_check_out.Controls.Add(this.panel6);
            this.tab_check_out.Controls.Add(this.panel3);
            this.tab_check_out.Controls.Add(this.panel2);
            this.tab_check_out.Controls.Add(this.panel1);
            this.tab_check_out.Controls.Add(this.payment_amount_tv);
            this.tab_check_out.Controls.Add(this.label3);
            this.tab_check_out.Controls.Add(this.label1);
            this.tab_check_out.Controls.Add(this.order_no_inp);
            this.tab_check_out.Controls.Add(this.cancel_payment_btn);
            this.tab_check_out.Controls.Add(this.button5);
            this.tab_check_out.Controls.Add(this.button4);
            this.tab_check_out.Controls.Add(this.button3);
            this.tab_check_out.Controls.Add(this.sale_btn);
            this.tab_check_out.Controls.Add(this.tip_amount_inp);
            this.tab_check_out.Controls.Add(this.amount_inp);
            this.tab_check_out.Controls.Add(this.disconnect);
            this.tab_check_out.Controls.Add(this.button1);
            this.tab_check_out.Location = new System.Drawing.Point(4, 25);
            this.tab_check_out.Name = "tab_check_out";
            this.tab_check_out.Padding = new System.Windows.Forms.Padding(3);
            this.tab_check_out.Size = new System.Drawing.Size(905, 507);
            this.tab_check_out.TabIndex = 0;
            this.tab_check_out.Text = "CheckOut";
            this.tab_check_out.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 54;
            this.label4.Text = "Refund Amount";
            // 
            // refund_btn
            // 
            this.refund_btn.Location = new System.Drawing.Point(193, 401);
            this.refund_btn.Name = "refund_btn";
            this.refund_btn.Size = new System.Drawing.Size(197, 38);
            this.refund_btn.TabIndex = 53;
            this.refund_btn.Text = "Refund";
            this.refund_btn.UseVisualStyleBackColor = true;
            this.refund_btn.Click += new System.EventHandler(this.refundPOS_Click);
            // 
            // refund_amount_inp
            // 
            this.refund_amount_inp.Location = new System.Drawing.Point(131, 410);
            this.refund_amount_inp.Name = "refund_amount_inp";
            this.refund_amount_inp.Size = new System.Drawing.Size(56, 25);
            this.refund_amount_inp.TabIndex = 52;
            // 
            // search_order_btn
            // 
            this.search_order_btn.Location = new System.Drawing.Point(193, 339);
            this.search_order_btn.Name = "search_order_btn";
            this.search_order_btn.Size = new System.Drawing.Size(197, 42);
            this.search_order_btn.TabIndex = 51;
            this.search_order_btn.Text = "search";
            this.search_order_btn.UseVisualStyleBackColor = true;
            this.search_order_btn.Click += new System.EventHandler(this.searchPOSOrder_Click);
            // 
            // hante_trans_id
            // 
            this.hante_trans_id.Location = new System.Drawing.Point(17, 350);
            this.hante_trans_id.Name = "hante_trans_id";
            this.hante_trans_id.Size = new System.Drawing.Size(170, 25);
            this.hante_trans_id.TabIndex = 50;
            this.hante_trans_id.Text = "Hante Trans ID";
            this.hante_trans_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.must_inp_num);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lab_connect_status);
            this.panel6.Location = new System.Drawing.Point(25, 128);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(365, 37);
            this.panel6.TabIndex = 49;
            // 
            // lab_connect_status
            // 
            this.lab_connect_status.AutoSize = true;
            this.lab_connect_status.Location = new System.Drawing.Point(7, 11);
            this.lab_connect_status.Name = "lab_connect_status";
            this.lab_connect_status.Size = new System.Drawing.Size(119, 15);
            this.lab_connect_status.TabIndex = 48;
            this.lab_connect_status.Text = "Connect Status";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lab_merchant_no);
            this.panel3.Location = new System.Drawing.Point(210, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 25);
            this.panel3.TabIndex = 47;
            // 
            // lab_merchant_no
            // 
            this.lab_merchant_no.AutoSize = true;
            this.lab_merchant_no.Location = new System.Drawing.Point(4, 5);
            this.lab_merchant_no.Name = "lab_merchant_no";
            this.lab_merchant_no.Size = new System.Drawing.Size(95, 15);
            this.lab_merchant_no.TabIndex = 46;
            this.lab_merchant_no.Text = "Merchant No";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lab_ip);
            this.panel2.Location = new System.Drawing.Point(25, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 25);
            this.panel2.TabIndex = 45;
            // 
            // lab_ip
            // 
            this.lab_ip.AutoSize = true;
            this.lab_ip.Location = new System.Drawing.Point(6, 6);
            this.lab_ip.Name = "lab_ip";
            this.lab_ip.Size = new System.Drawing.Size(23, 15);
            this.lab_ip.TabIndex = 44;
            this.lab_ip.Text = "IP";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.responseTv);
            this.panel1.Location = new System.Drawing.Point(537, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 284);
            this.panel1.TabIndex = 42;
            // 
            // responseTv
            // 
            this.responseTv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.responseTv.Location = new System.Drawing.Point(0, 0);
            this.responseTv.Name = "responseTv";
            this.responseTv.Size = new System.Drawing.Size(316, 284);
            this.responseTv.TabIndex = 16;
            // 
            // payment_amount_tv
            // 
            this.payment_amount_tv.AutoSize = true;
            this.payment_amount_tv.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.payment_amount_tv.Location = new System.Drawing.Point(602, 80);
            this.payment_amount_tv.Name = "payment_amount_tv";
            this.payment_amount_tv.Size = new System.Drawing.Size(152, 50);
            this.payment_amount_tv.TabIndex = 41;
            this.payment_amount_tv.Text = "$0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Amount";
            // 
            // order_no_inp
            // 
            this.order_no_inp.Location = new System.Drawing.Point(25, 278);
            this.order_no_inp.Name = "order_no_inp";
            this.order_no_inp.Size = new System.Drawing.Size(162, 25);
            this.order_no_inp.TabIndex = 38;
            this.order_no_inp.Text = "Order No";
            // 
            // cancel_payment_btn
            // 
            this.cancel_payment_btn.Location = new System.Drawing.Point(193, 268);
            this.cancel_payment_btn.Name = "cancel_payment_btn";
            this.cancel_payment_btn.Size = new System.Drawing.Size(197, 41);
            this.cancel_payment_btn.TabIndex = 37;
            this.cancel_payment_btn.Text = "Cancel Payment";
            this.cancel_payment_btn.UseVisualStyleBackColor = true;
            this.cancel_payment_btn.Click += new System.EventHandler(this.cancelPaymentPOS_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(295, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 36);
            this.button5.TabIndex = 36;
            this.button5.Text = "QR Code";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.qrCodePayment_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(193, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 36);
            this.button4.TabIndex = 35;
            this.button4.Text = "Scan Code";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.scanCodePayment_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(105, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 36);
            this.button3.TabIndex = 34;
            this.button3.Text = "Auth";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.authPOS_Click);
            // 
            // sale_btn
            // 
            this.sale_btn.Location = new System.Drawing.Point(25, 221);
            this.sale_btn.Name = "sale_btn";
            this.sale_btn.Size = new System.Drawing.Size(74, 36);
            this.sale_btn.TabIndex = 33;
            this.sale_btn.Text = "Sale\r\n";
            this.sale_btn.UseVisualStyleBackColor = true;
            this.sale_btn.Click += new System.EventHandler(this.salePOS_Click);
            // 
            // tip_amount_inp
            // 
            this.tip_amount_inp.Location = new System.Drawing.Point(244, 174);
            this.tip_amount_inp.Name = "tip_amount_inp";
            this.tip_amount_inp.Size = new System.Drawing.Size(146, 25);
            this.tip_amount_inp.TabIndex = 32;
            this.tip_amount_inp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.must_inp_num);
            // 
            // amount_inp
            // 
            this.amount_inp.Location = new System.Drawing.Point(85, 174);
            this.amount_inp.Name = "amount_inp";
            this.amount_inp.Size = new System.Drawing.Size(102, 25);
            this.amount_inp.TabIndex = 31;
            this.amount_inp.Text = "1";
            this.amount_inp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.must_inp_num);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(210, 80);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(180, 42);
            this.disconnect.TabIndex = 15;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnectPOS_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Connect POS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.connectConfig_Click);
            // 
            // tab_config
            // 
            this.tab_config.Controls.Add(this.config_notify_url_status);
            this.tab_config.Controls.Add(this.button8);
            this.tab_config.Controls.Add(this.config_notify_url_inp);
            this.tab_config.Controls.Add(this.button7);
            this.tab_config.Controls.Add(this.lab_config_sign_status);
            this.tab_config.Controls.Add(this.lab_config_pair_status);
            this.tab_config.Controls.Add(this.panel5);
            this.tab_config.Controls.Add(this.panel4);
            this.tab_config.Controls.Add(this.tsys_signin_btn);
            this.tab_config.Controls.Add(this.tsys_password_inp);
            this.tab_config.Controls.Add(this.pair_btn);
            this.tab_config.Controls.Add(this.verify_code_inp);
            this.tab_config.Controls.Add(this.button2);
            this.tab_config.Controls.Add(this.button6);
            this.tab_config.Controls.Add(this.merchant_no_inp);
            this.tab_config.Controls.Add(this.ip_inp);
            this.tab_config.Controls.Add(this.searchDevice);
            this.tab_config.Controls.Add(this.device_sn_inp);
            this.tab_config.Location = new System.Drawing.Point(4, 25);
            this.tab_config.Name = "tab_config";
            this.tab_config.Padding = new System.Windows.Forms.Padding(3);
            this.tab_config.Size = new System.Drawing.Size(905, 507);
            this.tab_config.TabIndex = 1;
            this.tab_config.Text = "Check Config";
            this.tab_config.UseVisualStyleBackColor = true;
            // 
            // config_notify_url_status
            // 
            this.config_notify_url_status.AutoSize = true;
            this.config_notify_url_status.Location = new System.Drawing.Point(22, 441);
            this.config_notify_url_status.Name = "config_notify_url_status";
            this.config_notify_url_status.Size = new System.Drawing.Size(0, 15);
            this.config_notify_url_status.TabIndex = 37;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(243, 390);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(209, 33);
            this.button8.TabIndex = 36;
            this.button8.Text = "Set Payment Notify";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.setPOSNotifyUrl_Click);
            // 
            // config_notify_url_inp
            // 
            this.config_notify_url_inp.Location = new System.Drawing.Point(22, 396);
            this.config_notify_url_inp.Name = "config_notify_url_inp";
            this.config_notify_url_inp.Size = new System.Drawing.Size(207, 25);
            this.config_notify_url_inp.TabIndex = 35;
            this.config_notify_url_inp.Text = "Payment Notify Url";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(349, 245);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 40);
            this.button7.TabIndex = 34;
            this.button7.Text = "ReSet";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.reSetPair_Click);
            // 
            // lab_config_sign_status
            // 
            this.lab_config_sign_status.AutoSize = true;
            this.lab_config_sign_status.Location = new System.Drawing.Point(22, 353);
            this.lab_config_sign_status.Name = "lab_config_sign_status";
            this.lab_config_sign_status.Size = new System.Drawing.Size(119, 15);
            this.lab_config_sign_status.TabIndex = 33;
            this.lab_config_sign_status.Text = "Sing In Status";
            // 
            // lab_config_pair_status
            // 
            this.lab_config_pair_status.AutoSize = true;
            this.lab_config_pair_status.Location = new System.Drawing.Point(23, 293);
            this.lab_config_pair_status.Name = "lab_config_pair_status";
            this.lab_config_pair_status.Size = new System.Drawing.Size(95, 15);
            this.lab_config_pair_status.TabIndex = 32;
            this.lab_config_pair_status.Text = "Pair Status";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lab_config_device_status);
            this.panel5.Location = new System.Drawing.Point(22, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(430, 33);
            this.panel5.TabIndex = 31;
            // 
            // lab_config_device_status
            // 
            this.lab_config_device_status.AutoSize = true;
            this.lab_config_device_status.Location = new System.Drawing.Point(7, 10);
            this.lab_config_device_status.Name = "lab_config_device_status";
            this.lab_config_device_status.Size = new System.Drawing.Size(111, 15);
            this.lab_config_device_status.TabIndex = 30;
            this.lab_config_device_status.Text = "Device Status";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lab_config_connect_status);
            this.panel4.Location = new System.Drawing.Point(22, 208);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(430, 30);
            this.panel4.TabIndex = 29;
            // 
            // lab_config_connect_status
            // 
            this.lab_config_connect_status.AutoSize = true;
            this.lab_config_connect_status.Location = new System.Drawing.Point(8, 9);
            this.lab_config_connect_status.Name = "lab_config_connect_status";
            this.lab_config_connect_status.Size = new System.Drawing.Size(119, 15);
            this.lab_config_connect_status.TabIndex = 28;
            this.lab_config_connect_status.Text = "Connect Status";
            // 
            // tsys_signin_btn
            // 
            this.tsys_signin_btn.Location = new System.Drawing.Point(243, 313);
            this.tsys_signin_btn.Name = "tsys_signin_btn";
            this.tsys_signin_btn.Size = new System.Drawing.Size(209, 37);
            this.tsys_signin_btn.TabIndex = 27;
            this.tsys_signin_btn.Text = "Tsys Signin";
            this.tsys_signin_btn.UseVisualStyleBackColor = true;
            this.tsys_signin_btn.Click += new System.EventHandler(this.signinPOS_Click);
            // 
            // tsys_password_inp
            // 
            this.tsys_password_inp.Location = new System.Drawing.Point(22, 321);
            this.tsys_password_inp.Name = "tsys_password_inp";
            this.tsys_password_inp.Size = new System.Drawing.Size(207, 25);
            this.tsys_password_inp.TabIndex = 26;
            this.tsys_password_inp.Text = "PassWord";
            // 
            // pair_btn
            // 
            this.pair_btn.Location = new System.Drawing.Point(243, 244);
            this.pair_btn.Name = "pair_btn";
            this.pair_btn.Size = new System.Drawing.Size(90, 41);
            this.pair_btn.TabIndex = 25;
            this.pair_btn.Text = "Pair";
            this.pair_btn.UseVisualStyleBackColor = true;
            this.pair_btn.Click += new System.EventHandler(this.pairPOS_Click);
            // 
            // verify_code_inp
            // 
            this.verify_code_inp.Location = new System.Drawing.Point(22, 255);
            this.verify_code_inp.Name = "verify_code_inp";
            this.verify_code_inp.Size = new System.Drawing.Size(207, 25);
            this.verify_code_inp.TabIndex = 24;
            this.verify_code_inp.Text = "verify code";
            this.verify_code_inp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.must_inp_num);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 42);
            this.button2.TabIndex = 21;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.disconnectPOS_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 158);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(207, 42);
            this.button6.TabIndex = 20;
            this.button6.Text = "Connect POS";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.connectConfig_Click);
            // 
            // merchant_no_inp
            // 
            this.merchant_no_inp.Location = new System.Drawing.Point(243, 115);
            this.merchant_no_inp.Name = "merchant_no_inp";
            this.merchant_no_inp.Size = new System.Drawing.Size(209, 25);
            this.merchant_no_inp.TabIndex = 7;
            this.merchant_no_inp.Text = "Merchant No";
            this.merchant_no_inp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.must_inp_num);
            // 
            // ip_inp
            // 
            this.ip_inp.Location = new System.Drawing.Point(22, 114);
            this.ip_inp.Name = "ip_inp";
            this.ip_inp.Size = new System.Drawing.Size(207, 25);
            this.ip_inp.TabIndex = 6;
            this.ip_inp.Text = "IP";
            // 
            // searchDevice
            // 
            this.searchDevice.Location = new System.Drawing.Point(243, 21);
            this.searchDevice.Name = "searchDevice";
            this.searchDevice.Size = new System.Drawing.Size(209, 47);
            this.searchDevice.TabIndex = 5;
            this.searchDevice.Text = "Search Device POS";
            this.searchDevice.UseVisualStyleBackColor = true;
            this.searchDevice.Click += new System.EventHandler(this.searchPOSDevice_Click);
            // 
            // device_sn_inp
            // 
            this.device_sn_inp.Location = new System.Drawing.Point(22, 34);
            this.device_sn_inp.Name = "device_sn_inp";
            this.device_sn_inp.Size = new System.Drawing.Size(207, 25);
            this.device_sn_inp.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 561);
            this.Controls.Add(this.tabControl);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.tab_check_out.ResumeLayout(false);
            this.tab_check_out.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tab_config.ResumeLayout(false);
            this.tab_config.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_check_out;
        private System.Windows.Forms.TabPage tab_config;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox order_no_inp;
        private System.Windows.Forms.Button cancel_payment_btn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button sale_btn;
        private System.Windows.Forms.TextBox tip_amount_inp;
        private System.Windows.Forms.TextBox amount_inp;
        private System.Windows.Forms.Label payment_amount_tv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label responseTv;
        private System.Windows.Forms.Button searchDevice;
        private System.Windows.Forms.TextBox device_sn_inp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lab_ip;
        private System.Windows.Forms.TextBox merchant_no_inp;
        private System.Windows.Forms.TextBox ip_inp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lab_merchant_no;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button tsys_signin_btn;
        private System.Windows.Forms.TextBox tsys_password_inp;
        private System.Windows.Forms.Button pair_btn;
        private System.Windows.Forms.TextBox verify_code_inp;
        private System.Windows.Forms.Label lab_config_connect_status;
        private System.Windows.Forms.Label lab_config_device_status;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lab_config_pair_status;
        private System.Windows.Forms.Label lab_config_sign_status;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lab_connect_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button refund_btn;
        private System.Windows.Forms.TextBox refund_amount_inp;
        private System.Windows.Forms.Button search_order_btn;
        private System.Windows.Forms.TextBox hante_trans_id;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox config_notify_url_inp;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label config_notify_url_status;
    }
}