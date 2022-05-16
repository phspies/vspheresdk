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
    public class VcenterNamespaceManagementVirtualMachineClassesDynamicDirectPathIodeviceType 
    {
        /// <summary>
        /// The vendor ID of this device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendor_id", Required = Required.AllowNull)]
        public long VendorId { get; set; }
        /// <summary>
        /// The device ID of this device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "device_id", Required = Required.AllowNull)]
        public long DeviceId { get; set; }
        /// <summary>
        /// The custom label attached to this device.
        /// If unset, custom label is not used to identify the device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "custom_label")]
        public string? CustomLabel { get; set; }
    }
}
