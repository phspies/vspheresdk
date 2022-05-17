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
    public class EsxSettingsClustersSoftwareReportsLastCheckResultCheckStatusType 
    {
        /// <summary>
        /// Information about this check.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "check", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsLastCheckResultCheckInfoType Check { get; set; }
        /// <summary>
        /// The status of this check.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsLastCheckResultStatusEnumType Status { get; set; }
        /// <summary>
        /// The issues encountered while running this check.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "issues", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdLocalizableMessageType> Issues { get; set; }
    }
}
