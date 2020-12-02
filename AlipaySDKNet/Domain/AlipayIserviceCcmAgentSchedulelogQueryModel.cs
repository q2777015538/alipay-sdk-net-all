using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmAgentSchedulelogQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmAgentSchedulelogQueryModel : AopObject
    {
        /// <summary>
        /// 客服id集合,限制最多100个id,不传查询部门下所有客服的状态变更流水日志
        /// </summary>
        [XmlArray("agent_ids")]
        [XmlArrayItem("string")]
        public List<string> AgentIds { get; set; }

        /// <summary>
        /// 客服状态变更结束时间,开始时间与结束时间间隔不能超过1天,采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd'T'HH:mm:ss'Z'
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 查询条数,最大100, 不传默认100
        /// </summary>
        [XmlElement("limit")]
        public long Limit { get; set; }

        /// <summary>
        /// 起始id,分页导出的起始客服状态变更流水id,第一页传0,翻页时传上一页结果的最大id
        /// </summary>
        [XmlElement("start_id")]
        public long StartId { get; set; }

        /// <summary>
        /// 客服状态变更开始时间,采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd'T'HH:mm:ss'Z'
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}