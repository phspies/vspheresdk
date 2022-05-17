using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Models
{
    public class EsxHclPcideviceType 
    {
        /// <summary>
        /// The device's address in a given ESXi host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pci_address", Required = Required.AllowNull)]
        public string PciAddress { get; set; }
        /// <summary>
        /// A unique number assigned to each computer hardware device that helps to identify the chipset manufacturer. For example,
        /// Dell, Broadcom, etc.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vid", Required = Required.AllowNull)]
        public string Vid { get; set; }
        /// <summary>
        /// A unique number that identifies the specific device of the Vendor (VID).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "did", Required = Required.AllowNull)]
        public string Did { get; set; }
        /// <summary>
        /// A unique number that identifies the card manufacturer.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "svid", Required = Required.AllowNull)]
        public string Svid { get; set; }
        /// <summary>
        /// A unique number that identifies the specific device of Subsystem Vendor (SVID).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssid", Required = Required.AllowNull)]
        public string Ssid { get; set; }
        /// <summary>
        /// The name of the vendor.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendor", Required = Required.AllowNull)]
        public string Vendor { get; set; }
        /// <summary>
        /// The name of the device model.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "model_name", Required = Required.AllowNull)]
        public string ModelName { get; set; }
        /// <summary>
        /// Register that specifies the type of function the device performs.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "class_code", Required = Required.AllowNull)]
        public string ClassCode { get; set; }
        /// <summary>
        /// Register that specifies the specific function the device performs.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sub_class_code", Required = Required.AllowNull)]
        public string SubClassCode { get; set; }
        /// <summary>
        /// Currently installed driver used by the device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "driver", Required = Required.AllowNull)]
        public EsxHclDriverType Driver { get; set; }
        /// <summary>
        /// Currently installed firmware used by the device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "firmware")]
        public EsxHclFirmwareType Firmware { get; set; }
        /// <summary>
        /// Shows whether the device is part of VSAN cluster or not.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "used_by_vsan", Required = Required.AllowNull)]
        public bool UsedByVsan { get; set; }
    }
}
