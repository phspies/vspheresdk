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
    public class EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesComplianceStatusReclassificationSpecType 
    {
        /// <summary>
        /// Information about the storage device for which this override must be applied to.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesComplianceStatusKeyType Key { get; set; }
        /// <summary>
        /// Compliance status override for the stroage device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "override")]
        public EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesComplianceStatusComplianceActionEnumType Override { get; set; }
    }
}
