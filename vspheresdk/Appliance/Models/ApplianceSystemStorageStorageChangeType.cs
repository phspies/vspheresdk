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
    public class ApplianceSystemStorageStorageChangeType 
    {
        /// <summary>
        /// Original size of the partition in MB.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "old_size", Required = Required.AllowNull)]
        public long OldSize { get; set; }
        /// <summary>
        /// Nedw size of the partition in MB.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "new_size", Required = Required.AllowNull)]
        public long NewSize { get; set; }
    }
}
