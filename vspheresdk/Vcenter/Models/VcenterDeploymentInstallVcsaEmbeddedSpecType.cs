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
    public class VcenterDeploymentInstallVcsaEmbeddedSpecType 
    {
        /// <summary>
        /// Spec used to configure a standalone embedded vCenter Server. This field describes how the standalone vCenter Server
        /// appliance should be configured.
        /// If unset, will default to None.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "standalone")]
        public VcenterDeploymentStandaloneSpecType Standalone { get; set; }
        /// <summary>
        /// Spec used to configure a replicated embedded vCenter Server. This field describes how the replicated vCenter Server
        /// appliance should be configured.
        /// If unset, will default to None.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "replicated")]
        public VcenterDeploymentReplicatedSpecType Replicated { get; set; }
        /// <summary>
        /// Whether CEIP should be enabled or disabled.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ceip_enabled", Required = Required.AllowNull)]
        public bool CeipEnabled { get; set; }
    }
}
