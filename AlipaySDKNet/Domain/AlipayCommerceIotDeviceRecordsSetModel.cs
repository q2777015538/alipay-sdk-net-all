using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceRecordsSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceRecordsSetModel : AopObject
    {
        /// <summary>
        /// 设备档案文件
        /// </summary>
        [XmlArray("device_record_files")]
        [XmlArrayItem("device_record_file")]
        public List<DeviceRecordFile> DeviceRecordFiles { get; set; }

        /// <summary>
        /// 设备档案拓展信息
        /// </summary>
        [XmlElement("ext_params")]
        public DeviceExtParams ExtParams { get; set; }

        /// <summary>
        /// 设备档案管理场景 IOT_DEVICE_RECORDS_G1(极简绑定) IOT_DEVICE_RECORDS_G3_INDIRECT(间连三绑定)  IOT_DEVICE_RECORDS_G3_DIRECT(直连三绑定) IOT_DEVICE_RECORDS_DELETE(解绑) IOT_DEVICE_RECORDS_QUERY（绑定查询）
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// CREATE UPDATE DEFAULT
        /// </summary>
        [XmlElement("scene_params")]
        public string SceneParams { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 设备供应商ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
