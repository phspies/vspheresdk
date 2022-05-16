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
    public class VcenterSystemConfigDeploymentTypeReconfigureType 
    {
        /// <summary>
        /// The type of the appliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterDeploymentApplianceType Type { get; set; }
        /// <summary>
        /// External PSC to register with when reconfiguring a VCSA_EMBEDDED appliance to a VCSA_EXTERNAL appliance.
        /// Only required when reconfiguring an VCSA_EMBEDDED node to a VCSA_EXTERNAL.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "remote_psc")]
        public VcenterDeploymentInstallRemotePscCheckType RemotePsc { get; set; }
    }
}
