using HanteTcpDemo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;

public class HttpServer
{
    private readonly string ipAddress;
    private readonly int port;
    private readonly HttpListener listener;

    public HttpServer(string ipAddress, int port)
    {
        this.ipAddress = ipAddress;
        this.port = port;
        listener = new HttpListener();
        listener.Prefixes.Add($"http://{ipAddress}:{port}/");
    }

    public void Start()
    {
        try
        {
            listener.Start();
            Console.WriteLine("服务器已启动，等待连接...");

            while (true)
            {
                HttpListenerContext context = listener.GetContext();
                ProcessRequest(context);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("服务器错误: " + ex.Message);
        }
    }

    public void Stop()
    {
        listener.Stop();
    }

    private void ProcessRequest(HttpListenerContext context)
    {
        HttpListenerRequest request = context.Request;
        HttpListenerResponse response = context.Response;

        // 在这里编写处理请求的逻辑

        // 检查请求的 HTTP 方法是否为 POST
        if (request.HttpMethod == "POST")
        {
            // 获取请求的内容长度
            int contentLength = (int)request.ContentLength64;

            // 创建一个字节数组来存储请求的内容
            byte[] bufferRead = new byte[contentLength];

            // 从请求的输入流中读取请求内容
            using (Stream inputStream = request.InputStream)
            {
                inputStream.Read(bufferRead, 0, contentLength);
            }

            // 将字节数组转换为字符串，根据需要进行编码转换
            string requestBody = System.Text.Encoding.UTF8.GetString(bufferRead);
            Console.WriteLine("POST 请求参数: orderNo:" + requestBody);

            // 解析JSON字符串
            JObject paymentResponse = JsonConvert.DeserializeObject<JObject>(requestBody);
            string orderNo = paymentResponse.GetValue("orderNo").ToString();
            string transactionId = paymentResponse.GetValue("transactionId").ToString();
            Console.WriteLine("POST 请求参数: orderNo:" + orderNo + "----transactionId:" + transactionId);

            byte[] bufferRes = System.Text.Encoding.UTF8.GetBytes("{\"result_code\":\"SUCCESS\"}");
            response.ContentLength64 = bufferRes.Length;
            response.OutputStream.Write(bufferRes, 0, bufferRes.Length);
            response.OutputStream.Close();

        }
        else {
            string responseString = "POS WEB";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);

            response.ContentLength64 = buffer.Length;
            response.OutputStream.Write(buffer, 0, buffer.Length);
            response.OutputStream.Close();
        }

        
    }
}
