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
    public class EsxSettingsBaseImageComplianceType 
    {
        /// <summary>
        /// Compliance status of the base image.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsComplianceStatusEnumType Status { get; set; }
        /// <summary>
        /// Current base image information on the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "current", Required = Required.AllowNull)]
        public EsxSettingsBaseImageInfoType Current { get; set; }
        /// <summary>
        /// Target base image information present in the software specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "target", Required = Required.AllowNull)]
        public EsxSettingsBaseImageInfoType Target { get; set; }
        /// <summary>
        /// Notifications describing the compliance result.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications", Required = Required.AllowNull)]
        public EsxSettingsNotificationsType Notifications { get; set; }
    }
}
