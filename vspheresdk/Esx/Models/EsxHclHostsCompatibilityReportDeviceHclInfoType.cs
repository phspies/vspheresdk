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
    public class EsxHclHostsCompatibilityReportDeviceHclInfoType 
    {
        /// <summary>
        /// Indicates compatibility status of the PCI device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "compatibility", Required = Required.AllowNull)]
        public EsxHclCompatibilityStatusEnumType Compatibility { get; set; }
        /// <summary>
        /// Information about the PCI device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "device", Required = Required.AllowNull)]
        public EsxHclPcideviceType Device { get; set; }
        /// <summary>
        /// Lists the constraints the target ESXi release has for this PCI device
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "device_constraints")]
        public Dictionary<string,EsxHclHostsCompatibilityReportDeviceConstraintType> DeviceConstraints { get; set; }
        /// <summary>
        /// Provides information about supported releases for this device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "supported_releases")]
        public IList<string> SupportedReleases { get; set; }
        /// <summary>
        /// Provides link to the VMware Compatibility Guide for further information on the compatibility.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vcg_link")]
        public string? VcgLink { get; set; }
        /// <summary>
        /// Information that needs to be taken into account when considering this device hcl.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public Dictionary<string,VapiStdLocalizableMessageType> Notes { get; set; }
    }
}
