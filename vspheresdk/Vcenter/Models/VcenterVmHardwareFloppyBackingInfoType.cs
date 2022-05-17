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
    public class VcenterVmHardwareFloppyBackingInfoType 
    {
        /// <summary>
        /// Backing type for the virtual floppy drive.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmHardwareFloppyBackingTypeEnum Type { get; set; }
        /// <summary>
        /// Path of the image file backing the virtual floppy drive.
        /// This field is optional and it is only relevant when the value of Floppy.BackingInfo.type is IMAGE_FILE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "image_file")]
        public string? ImageFile { get; set; }
        /// <summary>
        /// Name of the host device backing the virtual floppy drive.
        /// 
        /// 
        /// This field will be unset if Floppy.BackingInfo.auto-detect is true and the virtual floppy drive is not connected or no
        /// suitable device is available on the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_device")]
        public string? HostDevice { get; set; }
        /// <summary>
        /// Flag indicating whether the virtual floppy drive is configured to automatically detect a suitable host device.
        /// This field is optional and it is only relevant when the value of Floppy.BackingInfo.type is HOST_DEVICE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auto_detect")]
        public bool? AutoDetect { get; set; }
    }
}
