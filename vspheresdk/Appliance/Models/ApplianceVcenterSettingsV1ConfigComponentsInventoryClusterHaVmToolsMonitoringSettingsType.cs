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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaVmToolsMonitoringSettingsType 
    {
        /// <summary>
        /// Flag indicating whether or not the Virtual Machine Health Monitoring service is enabled.
        /// The Server does not use this property.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Flag indicating whether to use the cluster settings or the per VM settings.
        /// The default value is true.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster_settings")]
        public bool? ClusterSettings { get; set; }
        /// <summary>
        /// If no heartbeat has been received for at least the specified number of seconds, the virtual machine is declared as
        /// failed.
        /// The default value is 30.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "failure_interval")]
        public long? FailureInterval { get; set; }
        /// <summary>
        /// The number of seconds for the virtual machine's heartbeats to stabilize after the virtual machine has been powered on.
        /// This time should include the guest operating system boot-up time. The virtual machine monitoring will begin only after
        /// this period.
        /// The default value is 120.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "min_up_time")]
        public long? MinUpTime { get; set; }
        /// <summary>
        /// Maximum number of failures and automated resets allowed during the time that
        /// VmToolsMonitoringSettings.max-failure-window specifies. If VmToolsMonitoringSettings.max-failure-window is -1 (no
        /// window), this represents the absolute number of failures after which automated response is stopped.
        /// If a virtual machine exceeds this threshold, in-depth problem analysis is usually needed.
        /// 
        /// The default value is 3.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "max_failures")]
        public long? MaxFailures { get; set; }
        /// <summary>
        /// The number of seconds for the window during which up to VmToolsMonitoringSettings.max-failures resets can occur before
        /// automated responses stop.
        /// If set to -1, no failure window is specified.
        /// 
        /// The default value is -1.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "max_failure_window")]
        public long? MaxFailureWindow { get; set; }
    }
}
