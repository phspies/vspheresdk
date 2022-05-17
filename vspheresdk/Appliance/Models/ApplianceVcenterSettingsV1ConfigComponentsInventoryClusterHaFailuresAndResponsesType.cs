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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesType 
    {
        /// <summary>
        /// 
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_monitoring")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesServiceStateType HostMonitoring { get; set; }
        /// <summary>
        /// Restart priority for a virtual machine.
        /// If not specified at either the cluster level or the virtual machine level, this will default to medium.
        /// 
        /// 
        /// 
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_vm_restart_priority")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesRestartPriorityType DefaultVmRestartPriority { get; set; }
        /// <summary>
        /// This setting is used to specify a maximum time the lower priority VMs should wait for the higher priority VMs to be
        /// ready. If the higher priority Vms are not ready by this time, then the lower priority VMs are restarted irrespective of
        /// the VM ready state. This timeout can be used to prevent the failover of lower priority VMs to be stuck infinitely.
        /// Timeout specified in seconds. To use cluster setting for a VM override, set to -1 in per-VM. setting.
        /// 
        /// 
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "restart_priority_condition_timeout")]
        public long? RestartPriorityConditionTimeout { get; set; }
        /// <summary>
        /// After condition has been met, a mandatory delay before starting the next VM restart priority.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "additional_delay")]
        public long? AdditionalDelay { get; set; }
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
        [JsonProperty(PropertyName = "host_isolation_response")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesIsolationResponseType HostIsolationResponse { get; set; }
        /// <summary>
        /// VM storage protection setting for storage failures categorized as Permenant Device Loss (PDL). PDL indicates storage
        /// device failure or LUN removal. In case of PDL, the failed datastore or device is unlikely to recover. The details of PDL
        /// are
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore_with_pdl_failure_response", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesStorageVmReactionType DatastoreWithPdlFailureResponse { get; set; }
        /// <summary>
        /// VM storage protection setting for storage failures categorized as All Paths Down (APD). APD is a condition where a
        /// storage has become inaccessible for unknown reasons. It only indicates loss of connectivity and does not indicate
        /// storage device failure or LUN removal (Permanent Device Loss or PDL)
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "apd_failure_response", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesStorageVmReactionType ApdFailureResponse { get; set; }
        /// <summary>
        /// Action taken by VM Component Protection service for a powered on VM when APD condition clears after APD timeout.
        /// This property is meaningful only when vSphere HA is turned on. Valid values are specified by
        /// FailuresAndResponses.VmReactionOnAPDCleared. The default value is VmReactionOnAPDCleared#none for cluster setting and
        /// VmReactionOnAPDCleared#useClusterDefault for per-VM setting.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "response_recovery")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesVmReactionOnApdclearedType ResponseRecovery { get; set; }
        /// <summary>
        /// The time interval after an APD timeout has been declared and before VM Component Protection service will terminate the
        /// VM. The default value is 180 seconds if not specified. To use cluster setting for a VM override, set to -1 in per-VM
        /// setting.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "response_delay")]
        public long? ResponseDelay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_monitoring")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesVmMonitoringStateType VmMonitoring { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_tools_monitoring_settings")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaVmToolsMonitoringSettingsType VmToolsMonitoringSettings { get; set; }
    }
}
