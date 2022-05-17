using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceSystemStorageStorageMappingTypeA 
    {
        /// <summary>
        /// The disk number in the vSphere Web Client.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// appliance.system.storage. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: appliance.system.storage.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disk", Required = Required.AllowNull)]
        public string Disk { get; set; }
        /// <summary>
        /// Storage partition name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "partition", Required = Required.AllowNull)]
        public string Partition { get; set; }
        /// <summary>
        /// Description of partition
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public VapiStdLocalizableMessageTypeA Description { get; set; }
    }
}
