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
    public class ApplianceVcenterSettingsV1DesiredStateType 
    {
        /// <summary>
        /// Appliance Management component desired spec. Warning: This attribute is available as Technology Preview. These are early
        /// access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback,
        /// VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some
        /// Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "appliance")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtApplianceManagementType Appliance { get; set; }
        /// <summary>
        /// Authentication Management component desired spec. Warning: This attribute is available as Technology Preview. These are
        /// early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on
        /// feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "authmgmt")]
        public ApplianceVcenterSettingsV1ConfigComponentsAuthmanagementAuthenticationManagementType Authmgmt { get; set; }
        /// <summary>
        /// Inventory Configurations. Warning: This attribute is available as Technology Preview. These are early access APIs
        /// provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not
        /// guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview
        /// APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "inventory")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryInventoryManagementType Inventory { get; set; }
        /// <summary>
        /// Clientcapabilities Configurations. Warning: This attribute is available as Technology Preview. These are early access
        /// APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware
        /// does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology
        /// Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vsphereuiconfiguration")]
        public ApplianceVcenterSettingsV1ConfigComponentsVsphereuiconfigurationVsphereUiconfigurationType Vsphereuiconfiguration { get; set; }
        /// <summary>
        /// Inventory Authorization. Warning: This attribute is available as Technology Preview. These are early access APIs
        /// provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not
        /// guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview
        /// APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "invtauthmgmt")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryauthorizationInventoryAuthorizationType Invtauthmgmt { get; set; }
        /// <summary>
        /// Management Cluster Configurations. Warning: This attribute is available as Technology Preview. These are early access
        /// APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware
        /// does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology
        /// Preview APIs might only be applicable to specific environments.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "managementcluster")]
        public ApplianceVcenterSettingsV1ConfigComponentsManagementclusterManagementClusterType Managementcluster { get; set; }
    }
}
