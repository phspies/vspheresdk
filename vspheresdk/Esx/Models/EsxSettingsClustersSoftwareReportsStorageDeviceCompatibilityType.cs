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
    public class EsxSettingsClustersSoftwareReportsStorageDeviceCompatibilityType 
    {
        /// <summary>
        /// Compliance status of the storage device, when computed based on this VMware Compatibility Guide (VCG) listing.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsComplianceStatusType Status { get; set; }
        /// <summary>
        /// List of vSphere Versions compatible for this storage device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "compatible_versions")]
        public IList<string> CompatibleVersions { get; set; }
        /// <summary>
        /// List of minimum firmware versions supported from VMware Compatibility Guide (VCG) listing for the given vSphere version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "supported_firmware_versions")]
        public IList<string> SupportedFirmwareVersions { get; set; }
        /// <summary>
        /// Identifier of the VMware Compatibility Guide (VCG) listing for the product.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vcg_product", Required = Required.AllowNull)]
        public string VcgProduct { get; set; }
        /// <summary>
        /// Model name of the storage device as listed in the VMware Compatibility Guide (VCG) listing. This may not be the same as
        /// the {@link StorageDeviceInfo#model}
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "model", Required = Required.AllowNull)]
        public string Model { get; set; }
        /// <summary>
        /// OEM partner name of the storage device as listed in the VMware Compatibility Guide (VCG) listing.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "partner", Required = Required.AllowNull)]
        public string Partner { get; set; }
        /// <summary>
        /// Provides link to the VMware Compatibility Guide (VCG) listing for further information on the compatibility.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "compatibility_guide_link", Required = Required.AllowNull)]
        public string CompatibilityGuideLink { get; set; }
        /// <summary>
        /// Flag to indicate whether this VMware compatibility Guide (VCG) listing was used to compute the overall compatibility of
        /// the storage device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "used_for_compliance", Required = Required.AllowNull)]
        public bool UsedForCompliance { get; set; }
        /// <summary>
        /// Flag to indicate if the user has selected this VMware Compatibility Guide (VCG) listing to be considered to compute the
        /// overall compatibility of the storage device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "user_selected", Required = Required.AllowNull)]
        public bool UserSelected { get; set; }
        /// <summary>
        /// VMware compatibility Guide (VCG) listing specific notifications describing the compliance result.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications")]
        public EsxSettingsNotificationsType Notifications { get; set; }
    }
}
