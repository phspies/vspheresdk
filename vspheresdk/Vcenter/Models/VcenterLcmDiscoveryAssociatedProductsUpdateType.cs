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
    public class VcenterLcmDiscoveryAssociatedProductsUpdateType 
    {
        /// <summary>
        /// The list of hostname/IPs of the instances of the VMware products deployed in the environment.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "deployments")]
        public IList<string> Deployments { get; set; }
    }
}
