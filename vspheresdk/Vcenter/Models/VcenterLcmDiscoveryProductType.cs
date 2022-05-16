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
    public class VcenterLcmDiscoveryProductType 
    {
        /// <summary>
        /// Identifies a product and a version uniquely.
        /// The identifier consists of product internal name and version.
        /// 
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// PRODUCT. When operations return a value of this structure as a result, the field will be an identifier for the resource
        /// type: PRODUCT.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "installed_product", Required = Required.AllowNull)]
        public string InstalledProduct { get; set; }
        /// <summary>
        /// A public official product name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Current product version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// Future version of the product after upgrade.
        /// Product.target-version may not be applicable.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "target_version")]
        public string? TargetVersion { get; set; }
        /// <summary>
        /// The list of hostname/IPs of the instances of the VMware products deployed in the environment. This field would be empty
        /// for manually added products.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "deployments")]
        public IList<string> Deployments { get; set; }
        /// <summary>
        /// Indicates if the product is auto-detected by the system or manually added. If it is set to true it means it is
        /// auto-detected.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auto", Required = Required.AllowNull)]
        public bool Auto { get; set; }
    }
}
