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
    public class EsxSettingsHostComplianceType 
    {
        /// <summary>
        /// Overall impact.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "impact", Required = Required.AllowNull)]
        public EsxSettingsComplianceImpactType Impact { get; set; }
        /// <summary>
        /// Overall compliance state of the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsComplianceStatusType Status { get; set; }
        /// <summary>
        /// Notifications returned by the scan operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications", Required = Required.AllowNull)]
        public EsxSettingsNotificationsType Notifications { get; set; }
        /// <summary>
        /// Scan completion time.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scan_time", Required = Required.AllowNull)]
        public DateTime ScanTime { get; set; }
        /// <summary>
        /// Identifier of the commit on which the scan is run to generate this result.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "commit")]
        public string? Commit { get; set; }
        /// <summary>
        /// Compliance result for the base image.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "base_image", Required = Required.AllowNull)]
        public EsxSettingsBaseImageComplianceType BaseImage { get; set; }
        /// <summary>
        /// Compliance result for the OEM add-on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "add_on", Required = Required.AllowNull)]
        public EsxSettingsAddOnComplianceType AddOn { get; set; }
        /// <summary>
        /// Compliance result for hardware support (both Hardware Support Package or HSP and individual hardware module firmware)
        /// for every HSP configured, keyed by Hardware Support Manager (HSM).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hardware_support")]
        public Dictionary<string,EsxSettingsHardwareSupportPackageComplianceType>? HardwareSupport { get; set; }
        /// <summary>
        /// Compliance result for all the effective components and all the components present on the host. The key is the component
        /// name and value is the ComponentCompliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "components", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsComponentComplianceType> Components { get; set; }
        /// <summary>
        /// Compliance result for solutions. The key is the solution name and value is the SolutionCompliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutions", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsSolutionComplianceType> Solutions { get; set; }
    }
}
