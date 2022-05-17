using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The DrsConfig.DrsBehaviorInfo enumerated type defines the automation levels that can be set on a DRS cluster. Warning: This enumeration is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsManagementclusterDrsConfigDrsBehaviorInfoType
    {
        [EnumMember(Value = "MANUAL")]
        MANUAL = 1,
        [EnumMember(Value = "PARTIALLY_AUTOMATED")]
        PARTIALLYAUTOMATED = 2,
        [EnumMember(Value = "FULLY_AUTOMATED")]
        FULLYAUTOMATED = 3,
    }
}
