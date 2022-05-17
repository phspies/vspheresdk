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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaVsphereHatype 
    {
        /// <summary>
        /// HA Enabled or Disabled Flag to indicate whether or not vSphere HA feature is enabled.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
        /// <summary>
        /// Configuration settings for HA Failures and responses.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "failures_and_responses")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesType FailuresAndResponses { get; set; }
        /// <summary>
        /// Configuration settings for HA admission control.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "admission_control")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaAdmissionControlType AdmissionControl { get; set; }
        /// <summary>
        /// Configuration settings for heart beat data store policy.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "heartbeat_datastores")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaHeartBeatDataStoresType HeartbeatDatastores { get; set; }
        /// <summary>
        /// Advanced settings.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "advanced_options")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterOptionValueType> AdvancedOptions { get; set; }
    }
}
