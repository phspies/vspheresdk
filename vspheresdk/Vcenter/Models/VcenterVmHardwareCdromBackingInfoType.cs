using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterVmHardwareCdromBackingInfoType 
    {
        /// <summary>
        /// Backing type for the virtual CD-ROM device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmHardwareCdromBackingTypeEnum Type { get; set; }
        /// <summary>
        /// Path of the image file backing the virtual CD-ROM device.
        /// This field is optional and it is only relevant when the value of Cdrom.BackingInfo.type is ISO_FILE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "iso_file")]
        public string? IsoFile { get; set; }
        /// <summary>
        /// Name of the host device backing the virtual CD-ROM device.
        /// 
        /// 
        /// This field will be unset if Cdrom.BackingInfo.auto-detect is true and the virtual CD-ROM device is not connected or no
        /// suitable device is available on the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_device")]
        public string? HostDevice { get; set; }
        /// <summary>
        /// Flag indicating whether the virtual CD-ROM device is configured to automatically detect a suitable host device.
        /// This field is optional and it is only relevant when the value of Cdrom.BackingInfo.type is HOST_DEVICE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auto_detect")]
        public bool? AutoDetect { get; set; }
        /// <summary>
        /// Access type for the device backing.
        /// This field is optional and it is only relevant when the value of Cdrom.BackingInfo.type is one of HOST_DEVICE or
        /// CLIENT_DEVICE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "device_access_type")]
        public VcenterVmHardwareCdromDeviceAccessTypeEnum DeviceAccessType { get; set; }
    }
}
