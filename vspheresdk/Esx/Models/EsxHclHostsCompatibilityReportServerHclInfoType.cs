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
    public class EsxHclHostsCompatibilityReportServerHclInfoType 
    {
        /// <summary>
        /// Information about the server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        public EsxHclServerType Server { get; set; }
        /// <summary>
        /// Provides information about possible compatibility matches for the given server. <p> There could be multiple matches
        /// returned as there are several possible matches in the Compatibility data.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "matches", Required = Required.AllowNull)]
        public Dictionary<string,EsxHclHostsCompatibilityReportServerCompatibilityType> Matches { get; set; }
        /// <summary>
        /// Shows if the server model is compatible with given target ESXi release.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "model_compatibility", Required = Required.AllowNull)]
        public EsxHclCompatibilityStatusType ModelCompatibility { get; set; }
    }
}
