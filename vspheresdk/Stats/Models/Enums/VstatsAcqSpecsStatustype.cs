using System.Runtime.Serialization;

namespace vspheresdk.Stats.Models.Enums
{
    /// <summary>
    /// Describes the status of an Acquisition Specification. Warning: This enumeration is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.
    /// </summary>
    public enum VstatsAcqSpecsStatusType
    {
        [EnumMember(Value = "ENABLED")]
        ENABLED = 1,
        [EnumMember(Value = "DISABLED")]
        DISABLED = 2,
        [EnumMember(Value = "EXPIRED")]
        EXPIRED = 3,
    }
}
