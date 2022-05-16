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
    public class VcenterNamespaceManagementSupportBundleLocationType 
    {
        /// <summary>
        /// Support Bundle Download URL.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "url", Required = Required.AllowNull)]
        public string Url { get; set; }
        /// <summary>
        /// Information about the token required in the HTTP GET request to generate the support bundle.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "wcp_support_bundle_token", Required = Required.AllowNull)]
        public VcenterNamespaceManagementSupportBundleTokenType WcpSupportBundleToken { get; set; }
    }
}
