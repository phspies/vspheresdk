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
    public class VcenterOvfLibraryItemCreateType 
    {
        /// <summary>
        /// Identifier of the virtual machine or virtual appliance to use as the source.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source", Required = Required.AllowNull)]
        public VcenterOvfLibraryItemDeployableIdentityType Source { get; set; }
        /// <summary>
        /// Specification of the target content library and library item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "target", Required = Required.AllowNull)]
        public VcenterOvfLibraryItemCreateTargetType Target { get; set; }
        /// <summary>
        /// Information used to create the OVF package from the source virtual machine or virtual appliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "create_spec", Required = Required.AllowNull)]
        public VcenterOvfLibraryItemCreateSpecType CreateSpec { get; set; }
    }
}
