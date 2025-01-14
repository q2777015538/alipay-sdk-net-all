using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryChannelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryChannelInfo : AopObject
    {
        /// <summary>
        /// 展位码:boothCode表达的是具体渠道所属的展位码。例如：支付结果页PAYMENT_RESULT
        /// </summary>
        [XmlElement("booth_code")]
        public string BoothCode { get; set; }

        /// <summary>
        /// 可投放的渠道标识.  说明： 针对不同的boot_code，channel值各不相同.接口使用者可以认为channel是不同booth_code展位下的渠道的唯一标识。  例如： booth_code为PAYMENT_RESULT。 channel为某个商户的pid。
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 渠道的名称。  说明： booth_code：PAYMENT_RESULT，channel_name为商户名称。
        /// </summary>
        [XmlElement("channel_name")]
        public string ChannelName { get; set; }
    }
}
