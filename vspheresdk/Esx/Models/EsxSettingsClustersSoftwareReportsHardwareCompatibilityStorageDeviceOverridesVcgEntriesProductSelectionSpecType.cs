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
    public class EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesVcgEntriesProductSelectionSpecType 
    {
        /// <summary>
        /// Information about the storage device for which this override must be applied to.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesVcgEntriesKeyType Key { get; set; }
        /// <summary>
        /// VMware Compatibility Guide (VCG) product selection that  must be applied to the specified storage device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vcg_product")]
        public string? VcgProduct { get; set; }
    }
}
