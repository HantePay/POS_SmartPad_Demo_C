namespace HanteTcpDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ip_inp = new System.Windows.Forms.TextBox();
            this.merchant_no_inp = new System.Windows.Forms.TextBox();
            this.device_sn_inp = new System.Windows.Forms.TextBox();
            this.searchDevice = new System.Windows.Forms.Button();
            this.device_id_inp = new System.Windows.Forms.TextBox();
            this.token_inp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.amount_inp = new System.Windows.Forms.TextBox();
            this.tip_amount_inp = new System.Windows.Forms.TextBox();
            this.sale_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.content_status = new System.Windows.Forms.Label();
            this.responseTv = new System.Windows.Forms.Label();
            this.hante_trans_id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.verify_code_inp = new System.Windows.Forms.TextBox();
            this.pair_btn = new System.Windows.Forms.Button();
            this.tsys_password_inp = new System.Windows.Forms.TextBox();
            this.tsys_signin_btn = new System.Windows.Forms.Button();
            this.search_order_btn = new System.Windows.Forms.Button();
            this.refund_amount_inp = new System.Windows.Forms.TextBox();
            this.refund_btn = new System.Windows.Forms.Button();
            this.cancel_payment_btn = new System.Windows.Forms.Button();
            this.order_no_inp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.payment_amount_tv = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ip_inp
            // 
            this.ip_inp.Location = new System.Drawing.Point(68, 123);
            this.ip_inp.Name = "ip_inp";
            this.ip_inp.Size = new System.Drawing.Size(233, 25);
            this.ip_inp.TabIndex = 0;
            this.ip_inp.Text = "IP";
            this.ip_inp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // merchant_no_inp
            // 
            this.merchant_no_inp.Location = new System.Drawing.Point(326, 123);
            this.merchant_no_inp.Name = "merchant_no_inp";
            this.merchant_no_inp.Size = new System.Drawing.Size(257, 25);
            this.merchant_no_inp.TabIndex = 1;
            this.merchant_no_inp.Text = "Merchant No";
            // 
            // device_sn_inp
            // 
            this.device_sn_inp.Location = new System.Drawing.Point(68, 47);
            this.device_sn_inp.Name = "device_sn_inp";
            this.device_sn_inp.Size = new System.Drawing.Size(299, 25);
            this.device_sn_inp.TabIndex = 2;
            this.device_sn_inp.Text = "PD07P26L00132";
            // 
            // searchDevice
            // 
            this.searchDevice.Location = new System.Drawing.Point(416, 47);
            this.searchDevice.Name = "searchDevice";
            this.searchDevice.Size = new System.Drawing.Size(167, 47);
            this.searchDevice.TabIndex = 3;
            this.searchDevice.Text = "Search Device POS";
            this.searchDevice.UseVisualStyleBackColor = true;
            this.searchDevice.Click += new System.EventHandler(this.searchDevice_Click);
            // 
            // device_id_inp
            // 
            this.device_id_inp.Location = new System.Drawing.Point(68, 168);
            this.device_id_inp.Name = "device_id_inp";
            this.device_id_inp.Size = new System.Drawing.Size(233, 25);
            this.device_id_inp.TabIndex = 4;
            this.device_id_inp.Text = "Device ID";
            // 
            // token_inp
            // 
            this.token_inp.Location = new System.Drawing.Point(326, 167);
            this.token_inp.Name = "token_inp";
            this.token_inp.Size = new System.Drawing.Size(257, 25);
            this.token_inp.TabIndex = 5;
            this.token_inp.Text = "Token";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Connect POS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.connectPOS_Click);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(326, 218);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(257, 42);
            this.disconnect.TabIndex = 7;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // amount_inp
            // 
            this.amount_inp.Location = new System.Drawing.Point(128, 416);
            this.amount_inp.Name = "amount_inp";
            this.amount_inp.Size = new System.Drawing.Size(160, 25);
            this.amount_inp.TabIndex = 8;
            this.amount_inp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_must_num);
            // 
            // tip_amount_inp
            // 
            this.tip_amount_inp.Location = new System.Drawing.Point(364, 412);
            this.tip_amount_inp.Name = "tip_amount_inp";
            this.tip_amount_inp.Size = new System.Drawing.Size(218, 25);
            this.tip_amount_inp.TabIndex = 9;
            this.tip_amount_inp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_must_num);
            // 
            // sale_btn
            // 
            this.sale_btn.Location = new System.Drawing.Point(68, 471);
            this.sale_btn.Name = "sale_btn";
            this.sale_btn.Size = new System.Drawing.Size(123, 36);
            this.sale_btn.TabIndex = 10;
            this.sale_btn.Text = "Sale\r\n";
            this.sale_btn.UseVisualStyleBackColor = true;
            this.sale_btn.Click += new System.EventHandler(this.sale_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 36);
            this.button3.TabIndex = 11;
            this.button3.Text = "Auth";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.authPOS_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(327, 470);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 36);
            this.button4.TabIndex = 12;
            this.button4.Text = "Scan Code";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.scanCodePayment_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(464, 470);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 36);
            this.button5.TabIndex = 13;
            this.button5.Text = "QR Code";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.qrCodePayment_Click);
            // 
            // content_status
            // 
            this.content_status.AutoSize = true;
            this.content_status.Location = new System.Drawing.Point(8, 9);
            this.content_status.Name = "content_status";
            this.content_status.Size = new System.Drawing.Size(0, 15);
            this.content_status.TabIndex = 14;
            // 
            // responseTv
            // 
            this.responseTv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.responseTv.Location = new System.Drawing.Point(0, 0);
            this.responseTv.Name = "responseTv";
            this.responseTv.Size = new System.Drawing.Size(316, 284);
            this.responseTv.TabIndex = 16;
            this.responseTv.Text = "Response";
            // 
            // hante_trans_id
            // 
            this.hante_trans_id.Location = new System.Drawing.Point(68, 573);
            this.hante_trans_id.Name = "hante_trans_id";
            this.hante_trans_id.Size = new System.Drawing.Size(242, 25);
            this.hante_trans_id.TabIndex = 17;
            this.hante_trans_id.Text = "Hante Trans ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.responseTv);
            this.panel1.Location = new System.Drawing.Point(708, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 284);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.content_status);
            this.panel2.Location = new System.Drawing.Point(68, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 31);
            this.panel2.TabIndex = 19;
            // 
            // verify_code_inp
            // 
            this.verify_code_inp.Location = new System.Drawing.Point(68, 318);
            this.verify_code_inp.Name = "verify_code_inp";
            this.verify_code_inp.Size = new System.Drawing.Size(222, 25);
            this.verify_code_inp.TabIndex = 20;
            this.verify_code_inp.Text = "verify code";
            // 
            // pair_btn
            // 
            this.pair_btn.Location = new System.Drawing.Point(326, 307);
            this.pair_btn.Name = "pair_btn";
            this.pair_btn.Size = new System.Drawing.Size(257, 41);
            this.pair_btn.TabIndex = 21;
            this.pair_btn.Text = "Pair";
            this.pair_btn.UseVisualStyleBackColor = true;
            this.pair_btn.Click += new System.EventHandler(this.pairPOS_Click);
            // 
            // tsys_password_inp
            // 
            this.tsys_password_inp.Location = new System.Drawing.Point(68, 368);
            this.tsys_password_inp.Name = "tsys_password_inp";
            this.tsys_password_inp.Size = new System.Drawing.Size(222, 25);
            this.tsys_password_inp.TabIndex = 22;
            this.tsys_password_inp.Text = "PassWord";
            // 
            // tsys_signin_btn
            // 
            this.tsys_signin_btn.Location = new System.Drawing.Point(326, 360);
            this.tsys_signin_btn.Name = "tsys_signin_btn";
            this.tsys_signin_btn.Size = new System.Drawing.Size(256, 37);
            this.tsys_signin_btn.TabIndex = 23;
            this.tsys_signin_btn.Text = "Tsys Signin";
            this.tsys_signin_btn.UseVisualStyleBackColor = true;
            this.tsys_signin_btn.Click += new System.EventHandler(this.signinPOS_Click);
            // 
            // search_order_btn
            // 
            this.search_order_btn.Location = new System.Drawing.Point(327, 561);
            this.search_order_btn.Name = "search_order_btn";
            this.search_order_btn.Size = new System.Drawing.Size(255, 42);
            this.search_order_btn.TabIndex = 24;
            this.search_order_btn.Text = "search";
            this.search_order_btn.UseVisualStyleBackColor = true;
            this.search_order_btn.Click += new System.EventHandler(this.searchPOSOrder_Click);
            // 
            // refund_amount_inp
            // 
            this.refund_amount_inp.Location = new System.Drawing.Point(182, 633);
            this.refund_amount_inp.Name = "refund_amount_inp";
            this.refund_amount_inp.Size = new System.Drawing.Size(128, 25);
            this.refund_amount_inp.TabIndex = 25;
            this.refund_amount_inp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_must_num);
            // 
            // refund_btn
            // 
            this.refund_btn.Location = new System.Drawing.Point(326, 624);
            this.refund_btn.Name = "refund_btn";
            this.refund_btn.Size = new System.Drawing.Size(256, 38);
            this.refund_btn.TabIndex = 26;
            this.refund_btn.Text = "Refund";
            this.refund_btn.UseVisualStyleBackColor = true;
            this.refund_btn.Click += new System.EventHandler(this.refundPOS_Click);
            // 
            // cancel_payment_btn
            // 
            this.cancel_payment_btn.Location = new System.Drawing.Point(327, 512);
            this.cancel_payment_btn.Name = "cancel_payment_btn";
            this.cancel_payment_btn.Size = new System.Drawing.Size(255, 41);
            this.cancel_payment_btn.TabIndex = 27;
            this.cancel_payment_btn.Text = "Cancel Payment";
            this.cancel_payment_btn.UseVisualStyleBackColor = true;
            this.cancel_payment_btn.Click += new System.EventHandler(this.cancelPaymentPOS_Click);
            // 
            // order_no_inp
            // 
            this.order_no_inp.Location = new System.Drawing.Point(68, 528);
            this.order_no_inp.Name = "order_no_inp";
            this.order_no_inp.Size = new System.Drawing.Size(242, 25);
            this.order_no_inp.TabIndex = 28;
            this.order_no_inp.Text = "Order No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 638);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Refund Amount";
            // 
            // payment_amount_tv
            // 
            this.payment_amount_tv.AutoSize = true;
            this.payment_amount_tv.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.payment_amount_tv.Location = new System.Drawing.Point(771, 143);
            this.payment_amount_tv.Name = "payment_amount_tv";
            this.payment_amount_tv.Size = new System.Drawing.Size(152, 50);
            this.payment_amount_tv.TabIndex = 32;
            this.payment_amount_tv.Text = "$0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 711);
            this.Controls.Add(this.payment_amount_tv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.order_no_inp);
            this.Controls.Add(this.cancel_payment_btn);
            this.Controls.Add(this.refund_btn);
            this.Controls.Add(this.refund_amount_inp);
            this.Controls.Add(this.search_order_btn);
            this.Controls.Add(this.tsys_signin_btn);
            this.Controls.Add(this.tsys_password_inp);
            this.Controls.Add(this.pair_btn);
            this.Controls.Add(this.verify_code_inp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hante_trans_id);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.sale_btn);
            this.Controls.Add(this.tip_amount_inp);
            this.Controls.Add(this.amount_inp);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.token_inp);
            this.Controls.Add(this.device_id_inp);
            this.Controls.Add(this.searchDevice);
            this.Controls.Add(this.device_sn_inp);
            this.Controls.Add(this.merchant_no_inp);
            this.Controls.Add(this.ip_inp);
            this.Name = "Form1";
            this.Text = "Hante POS  Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip_inp;
        private System.Windows.Forms.TextBox merchant_no_inp;
        private System.Windows.Forms.TextBox device_sn_inp;
        private System.Windows.Forms.Button searchDevice;
        private System.Windows.Forms.TextBox device_id_inp;
        private System.Windows.Forms.TextBox token_inp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.TextBox amount_inp;
        private System.Windows.Forms.TextBox tip_amount_inp;
        private System.Windows.Forms.Button sale_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label content_status;
        private System.Windows.Forms.Label responseTv;
        private System.Windows.Forms.TextBox hante_trans_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox verify_code_inp;
        private System.Windows.Forms.Button pair_btn;
        private System.Windows.Forms.TextBox tsys_password_inp;
        private System.Windows.Forms.Button tsys_signin_btn;
        private System.Windows.Forms.Button search_order_btn;
        private System.Windows.Forms.TextBox refund_amount_inp;
        private System.Windows.Forms.Button refund_btn;
        private System.Windows.Forms.Button cancel_payment_btn;
        private System.Windows.Forms.TextBox order_no_inp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label payment_amount_tv;
    }
}

