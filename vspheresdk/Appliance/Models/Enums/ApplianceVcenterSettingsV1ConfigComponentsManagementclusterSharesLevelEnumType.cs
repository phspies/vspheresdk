using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Shares.Level enumerated type defines the possible values for the allocation level. Warning: This enumeration is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsManagementclusterSharesLevelEnumType
    {
        [EnumMember(Value = "LOW")]
        LOW = 1,
        [EnumMember(Value = "NORMAL")]
        NORMAL = 2,
        [EnumMember(Value = "HIGH")]
        HIGH = 3,
        [EnumMember(Value = "CUSTOM")]
        CUSTOM = 4,
    }
}
