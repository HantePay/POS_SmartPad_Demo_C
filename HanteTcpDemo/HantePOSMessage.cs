using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

internal class HantePOSMessage
{
    public string resultCode { get; set; }

    public string resultMsg { get; set; }


    public string type { get; set; }


    public string version { get; set; }


    public string verifyCode { get; set; }
    


    public string merchantNo { get; set; }


    public string notifyUrl { get; set; }
    

    public string deviceId { get; set; }

    public string desc { get; set; }
    

    public string orderNo { get; set; }

    public string signature { get; set; }


    public string title { get; set; }

    //金额 （单位:分）
    public string amount { get; set; }

    

    public string additionalCharges { get; set; }


    public string currency { get; set; }

    //支付场景 SCAN_CODE_PAYMENT : 付款码支付 QR_CODE_PAYMENT : 二维码支付 POS_PAYMENT : 刷卡支付 HANTE_CASHIER：汉特收银台
    public string paymentScenario { get; set; }

    //当payment 是creditcard时必传: AUTH 预授权 SALE 直接扣款 EBT
    public string transType { get; set; }

    public string transactionId { get; set; }
    
    //tsys 签到密码
    public string password { get; set; }


    public TokenInfo token { get; set; }
    public List<TokenInfo> tokenList { get; set; }



    //支付成功响应数据 总金额
    public string totalAmount { get; set; }

    //支付成功响应数据 收款方式
    public string paymentMethod { get; set; }

    //支付成功响应数据 信用卡类型
    public string cardType { get; set; }

    //支付成功响应数据 信用卡 卡号后4位
    public string cardNumber { get; set; }

    //支付成功响应数据 信用卡 auth Code
    public string authCode { get; set; }


    public void MD5Encrypt16(string token)
    {
        var sb = new StringBuilder();
        if (null != additionalCharges && additionalCharges.Length > 0) {
            sb.Append("additionalCharges=").Append(additionalCharges).Append("&");
        }

        if (null != amount && amount.Length > 0)
        {
            sb.Append("amount=").Append(amount).Append("&");
        }

        if (null != currency && currency.Length > 0)
        {
            sb.Append("currency=").Append(currency).Append("&");
        }


        if(null != desc && desc.Length > 0)
        {
            sb.Append("desc=").Append(desc).Append("&");
        }


        if (null != deviceId && deviceId.Length > 0)
        {
            sb.Append("deviceId=").Append(deviceId).Append("&");
        }

        if (null != merchantNo && merchantNo.Length > 0)
        {
            sb.Append("merchantNo=").Append(merchantNo).Append("&");
        }

        if (null != notifyUrl && notifyUrl.Length > 0)
        {
            sb.Append("notifyUrl=").Append(notifyUrl).Append("&");
        }


        if (null != orderNo && orderNo.Length > 0)
        {
            sb.Append("orderNo=").Append(orderNo).Append("&");
        }


       if (null != password && password.Length > 0)
        {
            sb.Append("password=").Append(password).Append("&");
        }

        if (null != paymentScenario && paymentScenario.Length > 0)
        {
            sb.Append("paymentScenario=").Append(paymentScenario).Append("&");
        }

        if (null != title && title.Length > 0)
        {
            sb.Append("title=").Append(title).Append("&");
        }

        
       if (null != transactionId && transactionId.Length > 0)
        {
            sb.Append("transactionId=").Append(transactionId).Append("&");
        }

        if (null != transType && transType.Length > 0)
        {
            sb.Append("transType=").Append(transType).Append("&");
        }

        if (null != type && type.Length > 0)
        {
            sb.Append("type=").Append(type).Append("&");
        }


        if (null != verifyCode && verifyCode.Length > 0)
        {
            sb.Append("verifyCode=").Append(verifyCode).Append("&");
        }

        if (null != version && version.Length > 0)
        {
            sb.Append("version=").Append(version).Append("&");
        }

        sb.Append(token);
        Console.WriteLine("MD5Encrypt16: " + sb.ToString());
        signature= MD5Utils.CalculateMD5(sb.ToString());
        Console.WriteLine("MD5Encrypt16: " + signature);
    }


}

internal class TokenInfo
{
    public string deviceId { get; set; }
    public string token { get; set; }

}
