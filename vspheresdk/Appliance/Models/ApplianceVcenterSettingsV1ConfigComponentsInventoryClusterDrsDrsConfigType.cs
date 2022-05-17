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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsDrsConfigType 
    {
        /// <summary>
        /// Flag indicating whether or not DRS service is enabled.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// vSphere HA configuration for Automation Level, Migration Threshold Predictive DRS and VM Automation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "automation")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsAutomationType Automation { get; set; }
        /// <summary>
        /// vSphere HA configuration for VM Distribution, CPU Over commit Scalable Shares.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "additional_options")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsAdditionalOptionsType AdditionalOptions { get; set; }
        /// <summary>
        /// vSphere HA configuration for DPM, AutomationLevel, DPM Threshold.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "power_management")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsPowerManagementType PowerManagement { get; set; }
    }
}
