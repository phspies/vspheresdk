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
    public class EsxHostsSoftwareInfoType 
    {
        /// <summary>
        /// Notifications returned by the get operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications", Required = Required.AllowNull)]
        public EsxHostsNotificationsType Notifications { get; set; }
        /// <summary>
        /// Host software information returned by the get operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "software_info", Required = Required.AllowNull)]
        public EsxHostsSoftwareInfoType SoftwareInfo { get; set; }
    }
}
