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
    public class VcenterLcmDiscoveryAssociatedProductsCreateSpecType 
    {
        /// <summary>
        /// The name of the product.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_name", Required = Required.AllowNull)]
        public string ProductName { get; set; }
        /// <summary>
        /// Current product version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// The list of hostname/IPs of the instances of the VMware products deployed in the environment.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "deployments")]
        public IList<string> Deployments { get; set; }
    }
}
