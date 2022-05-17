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
    public class EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesVcgEntriesUpdateSpecType 
    {
        /// <summary>
        /// List of VMware Compatibility Guide (VCG) overrides to be applied for the storage devices in a cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_selections", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesVcgEntriesProductSelectionSpecType> ProductSelections { get; set; }
    }
}
