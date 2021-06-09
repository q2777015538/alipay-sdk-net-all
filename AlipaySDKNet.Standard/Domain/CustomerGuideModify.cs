using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomerGuideModify Data Structure.
    /// </summary>
    [Serializable]
    public class CustomerGuideModify : AopObject
    {
        /// <summary>
        /// 券可使用的门店列表。 接口参数是列表类型。  限制： store_ids中的门店id必须是支付宝门店id。  store_ids如果包含重复的门店id会自动进行去重操作。  传入的store_ids中包含的门店id数量 <= 3000。  修改门店列表，只允许增加不允许减少。
        /// </summary>
        [XmlArray("store_ids")]
        [XmlArrayItem("string")]
        public List<string> StoreIds { get; set; }
    }
}
