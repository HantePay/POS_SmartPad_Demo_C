"# POS_SmartPad_Demo_C"  
Sunmi SmartPad <br/>
支持快捷键:*#00# 检查环境, *#01# 打开wiif <br/>
Hante POS 收款支持：信用卡,微信,支付宝 <br/>

原理:Sunmi SmartPad 作为 服务端 , Demo作为 客户端,使用Socket 交互<br/>


使用步骤：<br/>
第一步：导入: SocketUtils.cs文件 <br/>
第二步：获取 SmartPad 服务端 IP + 端口号<br/>
第三步: 使用 SocketUtils.cs 建立连接<br/>
   SocketClient socketHelper = new SocketClient();<br/>
   //连接socket ,状态回调托管 <br/>
   socketHelper.Connect(ip, 10010, ConnectedSuccess, ConnectedFail, POSHeartbeat, POSReceiveMessages);

   public void ConnectedSuccess() {//连接成功}

   public void ConnectedFail() {//连接失败}

   public void POSHeartbeat() {//心跳包}

   public void POSReceiveMessages(string msg) {
      //收到POS 服务端 响应消息
       //解析JSON 数据结果
        HantePOSMessage deciveResponse = JsonConvert.DeserializeObject<HantePOSMessage>(msg);
      //判断交易结果
      if ("transaction".Equals(deciveResponse.type)){
            //交易成功
            if ("SUCCESS".Equals(deciveResponse.resultCode)){
               //Hante交易流水号
               string transactionId=deciveResponse.transactionId;
            }
      }
   }

  使用SocketUtils.cs 发送消息(JSON格式)
   socketHelper.Send(string data)
   
   举例：发起交易
   
   socketHelper.Send(JsonConvert.SerializeObject({
      "type":"transaction",//交易
      "paymentScenario":"POS_PAYMENT",//POS_PAYMENT 刷卡,SCAN_CODE_PAYMENT 扫码收款，QR_CODE_PAYMENT二维码收款
      "amount":1,//交易金额 整数(单位：美分)
      "version":"V2",//版本固定V2
      "currency":"USD",//货币固定USD 
      "merchantNo":"1101301",//商户号
      "deviceId":"ht23983",//设备ID 配对获取
      "orderNo":"1654165464560",
      "desc":"订单备注",//订单备注
      "signature":"sludnf2349jflsjkdfsl22vd",//签名验证（HantePOSMessage.cs 查看签名会在）
   }))

   举例发起退款
   socketHelper.Send(JsonConvert.SerializeObject({
      "type":"transaction",//交易
      "paymentScenario":"POS_PAYMENT",//POS_PAYMENT 刷卡,SCAN_CODE_PAYMENT 扫码收款，QR_CODE_PAYMENT二维码收款
      "amount":1,//交易金额 整数(单位：美分)
      "version":"V2",//版本固定V2
      "currency":"USD",//货币固定USD 
      "merchantNo":"1101301",//商户号
      "deviceId":"ht23983",//设备ID 配对获取
      "transactionId":"202305264658461654564"
      "signature":"sludnf2349jflsjkdfsl22vd",//签名验证（HantePOSMessage.cs 查看签名会在）
   }))
