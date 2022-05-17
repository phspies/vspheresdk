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
    public class ApplianceVcenterSettingsV1ConfigComponentsManagementclusterManagementVirtualMachineType 
    {
        /// <summary>
        /// Name of the management virtual machine configuration. Warning: This attribute is available as Technology Preview. These
        /// are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on
        /// feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Type of the management virtual machine. Warning: This attribute is available as Technology Preview. These are early
        /// access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback,
        /// VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some
        /// Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_type", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsManagementclusterManagementVirtualMachineManagementVmtypeEnum VmType { get; set; }
        /// <summary>
        /// Absolute path from root folder to management virtual machine parent vm folder. Warning: This attribute is available as
        /// Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since
        /// this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them
        /// in production environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parent_path", Required = Required.AllowNull)]
        public string ParentPath { get; set; }
        /// <summary>
        /// Configuration of the management virtual machine. Warning: This attribute is available as Technology Preview. These are
        /// early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on
        /// feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// If unset, then there is no configuration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_config")]
        public ApplianceVcenterSettingsV1ConfigComponentsManagementclusterResourceConfigSpecType ResourceConfig { get; set; }
    }
}
