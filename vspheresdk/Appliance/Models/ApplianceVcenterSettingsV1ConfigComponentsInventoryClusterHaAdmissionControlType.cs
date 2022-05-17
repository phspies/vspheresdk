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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaAdmissionControlType 
    {
        /// <summary>
        /// Number of host failures that should be tolerated, still guaranteeing sufficient resources to restart virtual machines on
        /// available hosts. If not set, we assume 1.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_failures_cluster_tolerates")]
        public long? HostFailuresClusterTolerates { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "policy_type")]
        public string? PolicyType { get; set; }
        /// <summary>
        /// This policy allows setting a fixed slot size
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_fail_over_slot_policy")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFixedSizeSlotPolicyType HostFailOverSlotPolicy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster_resource_percentage")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaClusterResourcePercentageType ClusterResourcePercentage { get; set; }
        /// <summary>
        /// List of hosts dedicated for failover.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dedicated_failover_hosts")]
        public IList<string> DedicatedFailoverHosts { get; set; }
        /// <summary>
        /// Percentage of resource reduction that a cluster of VMs can tolerate in case of a failover.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "performance_degradation_vm_tolerate")]
        public long? PerformanceDegradationVmTolerate { get; set; }
    }
}
