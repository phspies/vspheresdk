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
    public class ApplianceSupportBundleCreateSpecType 
    {
        /// <summary>
        /// Support bundle creation description.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// Support bundle components to be included. Map with groupName as key and list of components in that group as the value.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "components")]
        public object Components { get; set; }
        /// <summary>
        /// Partition to be used for saving the support bundle. Available partitions can be retrieved using storage.list API.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "partition")]
        public string? Partition { get; set; }
    }
}
