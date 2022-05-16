using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterContentRegistriesHarborCreateSpecType 
    {
        /// <summary>
        /// Identifier of the cluster hosting the registry.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public string? Cluster { get; set; }
        /// <summary>
        /// Garbage collection configuration for the Harbor registry.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "garbage_collection")]
        public VcenterContentRegistriesHarborGarbageCollectionType GarbageCollection { get; set; }
        /// <summary>
        /// Storage associated with the Harbor registry. The list contains only one storage backing in this version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage", Required = Required.AllowNull)]
        public Dictionary<string,VcenterContentRegistriesHarborStorageSpecType> Storage { get; set; }
    }
}
