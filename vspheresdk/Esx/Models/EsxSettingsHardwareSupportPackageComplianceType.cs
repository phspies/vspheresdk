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
    public class EsxSettingsHardwareSupportPackageComplianceType 
    {
        /// <summary>
        /// Compliance status of the Hardware Support Package (HSP).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsComplianceStatusEnumType Status { get; set; }
        /// <summary>
        /// Current version of the Hardware Support Package present on the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "current")]
        public EsxSettingsHardwareSupportPackageInfoType Current { get; set; }
        /// <summary>
        /// Target version of the Hardware Support Package present in the software specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public EsxSettingsHardwareSupportPackageInfoType Target { get; set; }
        /// <summary>
        /// Compliance result for individual hardware module on the host. The key is the module identifier and value is the
        /// HardwareModuleFirmwareCompliance for the device. NOTE: if no individual hardware module compliance is returned by the,
        /// Hardware Support Manager (HSM), this map may have no entries even if ComplianceStatus = NON_COMPLIANT
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hardware_modules", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsHardwareModuleFirmwareComplianceType> HardwareModules { get; set; }
        /// <summary>
        /// Notifications describing the compliance result.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications", Required = Required.AllowNull)]
        public EsxSettingsNotificationsType Notifications { get; set; }
    }
}
