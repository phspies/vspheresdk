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
    public class VcenterNamespaceManagementHostsConfigInfoType 
    {
        /// <summary>
        /// True if vSphere Namespace feature is supported in this VC.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespaces_supported", Required = Required.AllowNull)]
        public bool NamespacesSupported { get; set; }
        /// <summary>
        /// True if vSphere Namespace feature is licensed on any hosts in this VC.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespaces_licensed", Required = Required.AllowNull)]
        public bool NamespacesLicensed { get; set; }
    }
}
