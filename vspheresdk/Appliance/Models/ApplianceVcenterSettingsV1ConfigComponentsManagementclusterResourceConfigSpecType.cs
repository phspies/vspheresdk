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
    public class ApplianceVcenterSettingsV1ConfigComponentsManagementclusterResourceConfigSpecType 
    {
        /// <summary>
        /// Resource allocation information for CPU. Warning: This attribute is available as Technology Preview. These are early
        /// access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback,
        /// VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some
        /// Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu_allocation", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsManagementclusterResourceAllocationInfoType CpuAllocation { get; set; }
        /// <summary>
        /// Resource allocation information for memory. Warning: This attribute is available as Technology Preview. These are early
        /// access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback,
        /// VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some
        /// Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory_allocation", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsManagementclusterResourceAllocationInfoType MemoryAllocation { get; set; }
    }
}
