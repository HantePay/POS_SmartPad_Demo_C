using System;
using System.IO;
using System.Net;

 public class HantePOSAPI
 {
     public static string SendGetRequest(string url)
     {
         string responseString = string.Empty;

         try
         {
             HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
             request.Method = "GET";

             using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
             {
                 using (Stream stream = response.GetResponseStream())
                 {
                     using (StreamReader reader = new StreamReader(stream))
                     {
                         responseString = reader.ReadToEnd();
                     }
                 }
             }
         }
         catch (Exception ex)
         {
             // 处理异常
             Console.WriteLine("发送GET请求出错：" + ex.Message);
         }

         return responseString;
     }

     public static string SendPostRequest(string url, string postData)
     {
         string responseString = string.Empty;

         try
         {
             byte[] data = System.Text.Encoding.UTF8.GetBytes(postData);

             HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
             request.Method = "POST";
             request.ContentType = "application/x-www-form-urlencoded";
             request.ContentLength = data.Length;

             using (Stream stream = request.GetRequestStream())
             {
                 stream.Write(data, 0, data.Length);
             }

             using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
             {
                 using (Stream stream = response.GetResponseStream())
                 {
                     using (StreamReader reader = new StreamReader(stream))
                     {
                         responseString = reader.ReadToEnd();
                     }
                 }
             }
         }
         catch (Exception ex)
         {
             // 处理异常
             Console.WriteLine("发送POST请求出错：" + ex.Message);
         }

         return responseString;
     }
 }

