using HanteTcpDemo;
using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

public class SocketClient
{
    private const int bufferSize = 1024;
    private byte[] buffer = new byte[bufferSize];
    private Socket clientSocket;

    //连接成功
    public delegate void ConnectedSuccess();

    //连接失败
    public delegate void ConnectedFail(string msg);

    //心跳包
    public delegate void Heartbeat();

    //收到消息
    public delegate void ReceivedMessage(string msg);


    Heartbeat heartbeatCallBack;

    ReceivedMessage receivedMessageCallBack;

    public void Connect(string ipAddress, int port, ConnectedSuccess connected, ConnectedFail connectFail, Heartbeat heartbeat, ReceivedMessage receivedMessage)
    {
        try
        {
            heartbeatCallBack = heartbeat;
            receivedMessageCallBack = receivedMessage;
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(ipAddress, port);
            Console.WriteLine("Connected to the server.");

            // 开始异步接收数据
            clientSocket.BeginReceive(buffer, 0, bufferSize, SocketFlags.None, new AsyncCallback(ReceiveCallback), null);
            connected();

          
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to connect to the server: " + ex.Message);
            connectFail(ex.Message);
        }
    }

    public void Send(string data)
    {
        try
        {

            byte[] byteData = Encoding.UTF8.GetBytes(data);
            
            clientSocket.Send(byteData); // 阻塞发送数据
             //clientSocket.BeginSend(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(SendCallback), null);
             //等待一段时间，以便接收服务器的响应
             //System.Threading.Thread.Sleep(2000);
             //发送结束符号
            byte[] byteEnd =new byte[]{255};
            clientSocket.Send(byteEnd);
          
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to send data to the server: " + ex.Message);
        }
    }

    private void ReceiveCallback(IAsyncResult result)
    {
        try
        {
            int bytesRead = clientSocket.EndReceive(result);
            if (bytesRead > 0)
            {
             
                string receivedData = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Received data: " + receivedData);

                if ("ok".Equals(receivedData))
                {
                    heartbeatCallBack();
                }
                else {
                    receivedMessageCallBack(receivedData);
                }
                // 继续异步接收数据
                clientSocket.BeginReceive(buffer, 0, bufferSize, SocketFlags.None, new AsyncCallback(ReceiveCallback), null);


          
            }
        }
        catch(Exception ex){
            Console.WriteLine("Failed to receive data from the server: " + ex.Message);
        }
    }

    private void SendCallback(IAsyncResult result)
    {
        try
        {
           int length= clientSocket.EndSend(result);
            Console.WriteLine("Data sent to the server.字节"+ length);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to send data to the server: " + ex.Message);
        }
    }

    public void Disconnect()
    {
        if (clientSocket != null && clientSocket.Connected)
        {
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
        }
    }
}
