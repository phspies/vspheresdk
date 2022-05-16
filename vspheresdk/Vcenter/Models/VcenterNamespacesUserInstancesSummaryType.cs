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
    public class VcenterNamespacesUserInstancesSummaryType 
    {
        /// <summary>
        /// Identifier of the namespace.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespaces.Instance. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.namespaces.Instance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespace", Required = Required.AllowNull)]
        public string NamespaceProperty { get; set; }
        /// <summary>
        /// IP address or FQDN of the API endpoint for the given namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_host", Required = Required.AllowNull)]
        public string MasterHost { get; set; }
    }
}
