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
    public class VcenterContentRegistriesHarborInfoTypeA 
    {
        /// <summary>
        /// Identifier of the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public string? Cluster { get; set; }
        /// <summary>
        /// Identifier of the Harbor namespace in case it is created in a Kubernetes environment.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespace")]
        public string? NamespaceProperty { get; set; }
        /// <summary>
        /// Version of the registry.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// The date and time when the harbor registry was created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "creation_time", Required = Required.AllowNull)]
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// URL to access the UI of the registry.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ui_access_url", Required = Required.AllowNull)]
        public string UiAccessUrl { get; set; }
        /// <summary>
        /// Harbor certificate chain in base64 format.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cert_chain", Required = Required.AllowNull)]
        public IList<string> CertChain { get; set; }
        /// <summary>
        /// Garbage collection information for the registry.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "garbage_collection", Required = Required.AllowNull)]
        public VcenterContentRegistriesHarborGarbageCollectionTypeA GarbageCollection { get; set; }
        /// <summary>
        /// Storage information associated with the registry.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage", Required = Required.AllowNull)]
        public Dictionary<string,VcenterContentRegistriesHarborStorageInfoTypeA> Storage { get; set; }
        /// <summary>
        /// Health status of the container registry.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "health", Required = Required.AllowNull)]
        public VcenterContentRegistriesHealthInfoTypeA Health { get; set; }
    }
}
