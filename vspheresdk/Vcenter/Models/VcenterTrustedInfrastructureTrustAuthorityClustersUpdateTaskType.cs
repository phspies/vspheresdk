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
    public class VcenterTrustedInfrastructureTrustAuthorityClustersUpdateTaskType 
    {
        /// <summary>
        /// The state of the TrustAuthorityClusters.
        /// state If {@term.unset} no operation is performed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public VcenterTrustedInfrastructureTrustAuthorityClustersStateType State { get; set; }
    }
}
