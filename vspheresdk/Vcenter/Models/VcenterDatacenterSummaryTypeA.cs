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
    public class VcenterDatacenterSummaryTypeA 
    {
        /// <summary>
        /// Identifier of the datacenter.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Datacenter. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: Datacenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datacenter", Required = Required.AllowNull)]
        public string Datacenter { get; set; }
        /// <summary>
        /// Name of the datacenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
    }
}
