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
    public class VcenterComputePoliciesCapabilitiesInfoType 
    {
        /// <summary>
        /// Name of the capability.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Description of the capability.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// Identifier of the {@term structure} used to create a policy based on this capability. See {@link
        /// vcenter.compute.Policies#create}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "create_spec_type", Required = Required.AllowNull)]
        public string CreateSpecType { get; set; }
        /// <summary>
        /// Identifier of the {@term structure} returned when retrieving information about a policy based on this capability. See
        /// {@link vcenter.compute.Policies#get}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "info_type", Required = Required.AllowNull)]
        public string InfoType { get; set; }
    }
}
