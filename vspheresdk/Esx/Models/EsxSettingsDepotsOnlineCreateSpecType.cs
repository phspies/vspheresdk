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
    public class EsxSettingsDepotsOnlineCreateSpecType 
    {
        /// <summary>
        /// Description of the depot.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Location of the depot. It should be the location to the index.xml for the depot.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location", Required = Required.AllowNull)]
        public string Location { get; set; }
        /// <summary>
        /// Flag indicating whether this depot is enabled or not. Disabling the depot doesn't delete its cached metadata and
        /// payloads. It will not be refreshed next time depots are re-synced.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Private data saved by the {@link Info#owner} of the depot. It is opaque to vLCM.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerdata")]
        public string? Ownerdata { get; set; }
    }
}
