"# POS_SmartPad_Demo_C"  Sunmi SmartPad 接入Hante 收款 支持：信用卡,微信,支付宝
原理:Sunmi SmartPad 作为 服务端 , Demo作为 客户端,使用Socket 交互
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

   public void POSReceiveMessages(string msg) {//收到POS 服务端 响应消息}

  使用SocketUtils.cs 发送消息(JSON格式)
   socketHelper.Send(string data)
   
