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
    public class VapiStdDynamicIdtypeA 
    {
        /// <summary>
        /// The type of resource being identified (for example {@code com.acme.Person}). <p> {@term Services} that contain {@term
        /// operations} for creating and deleting resources typically contain a {@term constant} specifying the resource type for
        /// the resources being created and deleted. The API metamodel metadata {@term services} include a {@term service} that
        /// allows retrieving all the known resource types.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public string Type { get; set; }
        /// <summary>
        /// The identifier for a resource whose type is specified by {@link #type}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
    }
}
