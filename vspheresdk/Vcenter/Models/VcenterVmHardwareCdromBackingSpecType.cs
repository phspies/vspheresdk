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
    public class VcenterVmHardwareCdromBackingSpecType 
    {
        /// <summary>
        /// Backing type for the virtual CD-ROM device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmHardwareCdromBackingTypeEnum Type { get; set; }
        /// <summary>
        /// Path of the image file that should be used as the virtual CD-ROM device backing.
        /// This field is optional and it is only relevant when the value of Cdrom.BackingSpec.type is ISO_FILE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "iso_file")]
        public string? IsoFile { get; set; }
        /// <summary>
        /// Name of the device that should be used as the virtual CD-ROM device backing.
        /// If unset, the virtual CD-ROM device will be configured to automatically detect a suitable host device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_device")]
        public string? HostDevice { get; set; }
        /// <summary>
        /// Access type for the device backing.
        /// If unset, defaults to EMULATION.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "device_access_type")]
        public VcenterVmHardwareCdromDeviceAccessTypeEnum DeviceAccessType { get; set; }
    }
}
