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
    public class VcenterNamespacesNamespaceTemplatesSummaryType 
    {
        /// <summary>
        /// Identifier for the vSphere cluster associated with namespace template.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster", Required = Required.AllowNull)]
        public string Cluster { get; set; }
        /// <summary>
        /// Name of the namespace template.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespaces.NamespaceTemplate. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.namespaces.NamespaceTemplate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "template", Required = Required.AllowNull)]
        public string Template { get; set; }
    }
}
