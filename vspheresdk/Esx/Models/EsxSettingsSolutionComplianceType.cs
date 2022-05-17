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
    public class EsxSettingsSolutionComplianceType 
    {
        /// <summary>
        /// Compliance status of the solution.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsComplianceStatusEnumType Status { get; set; }
        /// <summary>
        /// Current solution present on the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "current")]
        public EsxSettingsSolutionInfoType Current { get; set; }
        /// <summary>
        /// Target solution present in the software specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public EsxSettingsSolutionInfoType Target { get; set; }
        /// <summary>
        /// Notifications describing the compliance result.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications", Required = Required.AllowNull)]
        public EsxSettingsNotificationsType Notifications { get; set; }
    }
}
