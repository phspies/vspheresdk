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
    public class EsxSettingsHardwareModuleFirmwareComplianceType 
    {
        /// <summary>
        /// Compliance status of the hardware module's firmware.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsComplianceStatusType Status { get; set; }
        /// <summary>
        /// Additional details about the hardware module itself
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public EsxSettingsHardwareModuleDetailsType Details { get; set; }
        /// <summary>
        /// Current version of the firmware present on the host hardware module.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "current")]
        public EsxSettingsHardwareModuleFirmwareInfoType Current { get; set; }
        /// <summary>
        /// Target version of the firmware present in the Hardware Support Package (HSP).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public EsxSettingsHardwareModuleFirmwareInfoType Target { get; set; }
        /// <summary>
        /// Notifications describing the compliance result.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications", Required = Required.AllowNull)]
        public EsxSettingsNotificationsType Notifications { get; set; }
    }
}
