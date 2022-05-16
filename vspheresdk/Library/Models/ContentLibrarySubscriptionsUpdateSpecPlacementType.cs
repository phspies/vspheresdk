using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Library.Models.Enums;

namespace vspheresdk.Library.Models
{
    public class ContentLibrarySubscriptionsUpdateSpecPlacementType 
    {
        /// <summary>
        /// Virtual machine folder into which the virtual machine template should be placed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "folder")]
        public string? Folder { get; set; }
        /// <summary>
        /// Cluster onto which the virtual machine template should be placed. If {@name #cluster} and {@name #resourcePool} are both
        /// specified, {@name #resourcePool} must belong to {@name #cluster}. If {@name #cluster} and {@name #host} are both
        /// specified, {@name #host} must be a member of {@name #cluster}. If {@name #resourcePool} or {@name #host} is specified,
        /// it is recommended that this {@term field} be {@term unset}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public string? Cluster { get; set; }
        /// <summary>
        /// Resource pool into which the virtual machine template should be placed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_pool")]
        public string? ResourcePool { get; set; }
        /// <summary>
        /// Host onto which the virtual machine template should be placed. If {@name #host} and {@name #resourcePool} are both
        /// specified, {@name #resourcePool} must belong to {@name #host}. If {@name #host} and {@name #cluster} are both specified,
        /// {@name #host} must be a member of {@name #cluster}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
        /// <summary>
        /// Network that backs the virtual Ethernet adapters in the virtual machine template.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public string? Network { get; set; }
    }
}
