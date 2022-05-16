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
    public class VcenterSystemConfigPscRegistrationRepointTypeA 
    {
        /// <summary>
        /// RemotePscSpec structure containing information about the external PSC node to repoint this vCenter Server appliance to.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec", Required = Required.AllowNull)]
        public VcenterDeploymentRemotePscSpecTypeA Spec { get; set; }
    }
}
