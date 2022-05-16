using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Library.Models.Enums;

namespace vspheresdk.Library.Models
{
    public class ContentLibrarySubscriptionsVcenterInfoTypeA 
    {
        /// <summary>
        /// Hostname of the vCenter Server instance where the subscribed library exists.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hostname", Required = Required.AllowNull)]
        public string Hostname { get; set; }
        /// <summary>
        /// The HTTPS port of the vCenter Server instance where the subscribed library exists.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "https_port")]
        public long? HttpsPort { get; set; }
        /// <summary>
        /// The unique identifier of the vCenter Server where the subscribed library exists.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "server_guid", Required = Required.AllowNull)]
        public string ServerGuid { get; set; }
    }
}
