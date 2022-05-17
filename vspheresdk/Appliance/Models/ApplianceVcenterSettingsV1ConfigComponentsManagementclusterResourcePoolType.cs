using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceVcenterSettingsV1ConfigComponentsManagementclusterResourcePoolType 
    {
        /// <summary>
        /// Name of the vCenter Server resource pool. Warning: This attribute is available as Technology Preview. These are early
        /// access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback,
        /// VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some
        /// Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Absolute path from root folder to resource pool's parent. Warning: This attribute is available as Technology Preview.
        /// These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based
        /// on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parent_path", Required = Required.AllowNull)]
        public string ParentPath { get; set; }
        /// <summary>
        /// Summary of the resource pool containing the resource spec. Warning: This attribute is available as Technology Preview.
        /// These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based
        /// on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsManagementclusterResourceConfigSpecType Config { get; set; }
        /// <summary>
        /// The management virtual machines contained in this resource pool. Warning: This attribute is available as Technology
        /// Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can
        /// change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in
        /// production environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// If unset or empty, no virtual machine is expected to run in this resource pool..
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsManagementclusterManagementVirtualMachineType> Vm { get; set; }
    }
}
