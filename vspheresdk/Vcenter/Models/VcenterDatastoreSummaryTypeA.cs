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
    public class VcenterDatastoreSummaryTypeA 
    {
        /// <summary>
        /// Identifier of the datastore.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Datastore. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: Datastore.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore", Required = Required.AllowNull)]
        public string Datastore { get; set; }
        /// <summary>
        /// Name of the datastore.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Type (Type) of the datatore.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterDatastoreTypeEnumA Type { get; set; }
        /// <summary>
        /// Available space of this datastore, in bytes.
        /// The server periodically updates this value.
        /// 
        /// This field will be unset if the available space of this datastore is not known.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "free_space")]
        public long? FreeSpace { get; set; }
        /// <summary>
        /// Capacity of this datastore, in bytes.
        /// The server periodically updates this value.
        /// 
        /// This field will be unset if the capacity of this datastore is not known.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public long? Capacity { get; set; }
    }
}
