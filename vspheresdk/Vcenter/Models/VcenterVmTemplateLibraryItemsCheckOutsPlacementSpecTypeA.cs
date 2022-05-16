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
    public class VcenterVmTemplateLibraryItemsCheckOutsPlacementSpecTypeA 
    {
        /// <summary>
        /// Virtual machine folder into which the virtual machine should be placed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "folder")]
        public string? Folder { get; set; }
        /// <summary>
        /// Resource pool into which the virtual machine should be placed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_pool")]
        public string? ResourcePool { get; set; }
        /// <summary>
        /// Host onto which the virtual machine should be placed. If {@name #host} and {@name #resourcePool} are both specified,
        /// {@name #resourcePool} must belong to {@name #host}. If {@name #host} and {@name #cluster} are both specified, {@name
        /// #host} must be a member of {@name #cluster}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
        /// <summary>
        /// Cluster onto which the virtual machine should be placed. If {@name #cluster} and {@name #resourcePool} are both
        /// specified, {@name #resourcePool} must belong to {@name #cluster}. If {@name #cluster} and {@name #host} are both
        /// specified, {@name #host} must be a member of {@name #cluster}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public string? Cluster { get; set; }
    }
}
