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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaHaVmOverridesType 
    {
        /// <summary>
        /// Reference to the virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Restart priority for a virtual machine.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_restart_priority")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesRestartPriorityEnumType VmRestartPriority { get; set; }
        /// <summary>
        /// After condition has been met, a mandatory delay before starting the next VM restart priority.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_additional_delay")]
        public long? VmAdditionalDelay { get; set; }
        /// <summary>
        /// This setting is used to specify a maximum time the lower priority VMs should wait for the higher priority VMs to be
        /// ready. If the higher priority Vms are not ready by this time, then the lower priority VMs are restarted irrespective of
        /// the VM ready state. This timeout can be used to prevent the failover of lower priority VMs to be stuck infinitely.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_restart_priority_timeout")]
        public long? VmRestartPriorityTimeout { get; set; }
        /// <summary>
        /// Indicates whether or not the virtual machine should be powered off if a host determines that it is isolated from the
        /// rest of the compute resource.
        /// If not specified at either the cluster level or the virtual machine level, this will default to powerOff.
        /// 
        /// 
        /// 
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_isolation_response")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesIsolationResponseEnumType VmIsolationResponse { get; set; }
        /// <summary>
        /// VM storage protection setting for storage failures categorized as Permenant Device Loss (PDL). PDL indicates storage
        /// device failure or LUN removal. In case of PDL, the failed datastore or device is unlikely to recover. The details of PDL
        /// are
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_datastore_with_pdl_failure_response", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesStorageVmReactionEnumType VmDatastoreWithPdlFailureResponse { get; set; }
        /// <summary>
        /// VM storage protection setting for storage failures categorized as All Paths Down (APD). APD is a condition where a
        /// storage has become inaccessible for unknown reasons. It only indicates loss of connectivity and does not indicate
        /// storage device failure or LUN removal (Permanent Device Loss or PDL)
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_apd_failure_response", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesStorageVmReactionEnumType VmApdFailureResponse { get; set; }
        /// <summary>
        /// The time interval after an APD timeout has been declared and before VM Component Protection service will terminate the
        /// VM. The default value is 180 seconds if not specified. To use cluster setting for a VM override, set to -1 in per-VM
        /// setting.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_apd_failover_delay")]
        public long? VmApdFailoverDelay { get; set; }
        /// <summary>
        /// Action taken by VM Component Protection service for a powered on VM when APD condition clears after APD timeout. This
        /// property is meaningful only when vSphere HA is turned on. Valid values are
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_apd_response_recovery")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesVmReactionOnApdclearedEnumType VmApdResponseRecovery { get; set; }
        /// <summary>
        /// Virtual machine health monitoring is disabled. In this state, HA response to guest and application heartbeat failures
        /// are disabled.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_monitoring")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesVmMonitoringStateEnumType VmMonitoring { get; set; }
    }
}
