using System.Runtime.Serialization;

namespace vspheresdk.Stats.Models.Enums
{
    /// <summary>
    /// Counter metadata status. Warning: This enumeration is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.
    /// </summary>
    public enum VstatsCounterMetadataCounterEditionStatusEnumType
    {
        [EnumMember(Value = "DEFAULT")]
        DEFAULT = 1,
        [EnumMember(Value = "CURRENT")]
        CURRENT = 2,
        [EnumMember(Value = "DEPRECATED")]
        DEPRECATED = 3,
        [EnumMember(Value = "EXPERIMENTAL")]
        EXPERIMENTAL = 4,
        [EnumMember(Value = "REMOVED")]
        REMOVED = 5,
    }
}
