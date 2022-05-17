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
    public class EsxSettingsDepotsOnlineInfoType 
    {
        /// <summary>
        /// Description of the depot. It will be an empty string if no description was provided during create.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// Location of the depot.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location", Required = Required.AllowNull)]
        public string Location { get; set; }
        /// <summary>
        /// Flag indicating whether this depot is enabled or not.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
        /// <summary>
        /// Flag to indicate if the  depot is system defined. System defined depot can not be deleted.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "system_defined", Required = Required.AllowNull)]
        public bool SystemDefined { get; set; }
        /// <summary>
        /// Name of the user creating the depot.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public string? Owner { get; set; }
        /// <summary>
        /// Private data saved by the {@name #owner} of depot. It is opaque to vLCM.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerdata")]
        public string? Ownerdata { get; set; }
    }
}
