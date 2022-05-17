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
    public class EsxSettingsAddOnComplianceType 
    {
        /// <summary>
        /// Compliance status of the OEM add-on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsComplianceStatusEnumType Status { get; set; }
        /// <summary>
        /// Current OEM add-on present on the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "current")]
        public EsxSettingsAddOnInfoType Current { get; set; }
        /// <summary>
        /// Target OEM add-on present in the software specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public EsxSettingsAddOnInfoType Target { get; set; }
        /// <summary>
        /// Notifications describing the compliance result.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications", Required = Required.AllowNull)]
        public EsxSettingsNotificationsType Notifications { get; set; }
    }
}
