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
    public class VcenterOvfLibraryItemOvfSummaryTypeA 
    {
        /// <summary>
        /// Default name for the virtual machine or virtual appliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Default annotation for the virtual machine or virtual appliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "annotation")]
        public string? Annotation { get; set; }
        /// <summary>
        /// End User License Agreements specified in the OVF descriptor. All end user license agreements must be accepted in order
        /// for the {@name LibraryItem#deploy} {@term operation} to succeed. See {@link ResourcePoolDeploymentSpec#acceptAllEula}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "EULAs", Required = Required.AllowNull)]
        public IList<string> EUlas { get; set; }
        /// <summary>
        /// Section identifiers for sections of type ovf:NetworkSection in the OVF descriptor. These identifiers can be used as keys
        /// in {@link ResourcePoolDeploymentSpec#networkMappings}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "networks")]
        public IList<string> Networks { get; set; }
        /// <summary>
        /// Section identifiers for sections of type vmw:StorageGroupSection in the OVF descriptor. These identifiers can be used as
        /// keys in {@link ResourcePoolDeploymentSpec#storageMappings}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_groups")]
        public IList<string> StorageGroups { get; set; }
        /// <summary>
        /// Additional OVF parameters which can be specified for the deployment target. These OVF parameters can be inspected,
        /// optionally modified, and used as values in {@link ResourcePoolDeploymentSpec#additionalParameters} for the {@name
        /// LibraryItem#deploy} {@term operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "additional_params")]
        public IList<object> AdditionalParams { get; set; }
    }
}
