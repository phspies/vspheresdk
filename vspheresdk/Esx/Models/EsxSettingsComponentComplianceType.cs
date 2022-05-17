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
    public class EsxSettingsComponentComplianceType 
    {
        /// <summary>
        /// Compliance status of the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsComplianceStatusEnumType Status { get; set; }
        /// <summary>
        /// Current version of the component present on the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "current")]
        public EsxSettingsComponentInfoType Current { get; set; }
        /// <summary>
        /// Target version of the component present in the software specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public EsxSettingsComponentInfoType Target { get; set; }
        /// <summary>
        /// Source of the component on the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "current_source")]
        public EsxSettingsComponentSourceEnumType CurrentSource { get; set; }
        /// <summary>
        /// Source of the component in the software specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "target_source")]
        public EsxSettingsComponentSourceEnumType TargetSource { get; set; }
        /// <summary>
        /// Notifications describing the compliance result.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications", Required = Required.AllowNull)]
        public EsxSettingsNotificationsType Notifications { get; set; }
    }
}
