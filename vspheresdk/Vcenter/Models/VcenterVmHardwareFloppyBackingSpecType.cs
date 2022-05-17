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
    public class VcenterVmHardwareFloppyBackingSpecType 
    {
        /// <summary>
        /// Backing type for the virtual floppy drive.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmHardwareFloppyBackingTypeEnum Type { get; set; }
        /// <summary>
        /// Path of the image file that should be used as the virtual floppy drive backing.
        /// This field is optional and it is only relevant when the value of Floppy.BackingSpec.type is IMAGE_FILE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "image_file")]
        public string? ImageFile { get; set; }
        /// <summary>
        /// Name of the device that should be used as the virtual floppy drive backing.
        /// If unset, the virtual floppy drive will be configured to automatically detect a suitable host device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_device")]
        public string? HostDevice { get; set; }
    }
}
