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
    public class EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesComplianceStatusUpdateSpecType 
    {
        /// <summary>
        /// List of compatibility  overrides to be applied for the storage devices in a cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "device_reclassifications", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesComplianceStatusReclassificationSpecType> DeviceReclassifications { get; set; }
    }
}
