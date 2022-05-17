using System.Runtime.Serialization;

namespace vspheresdk.Stats.Models.Enums
{
    /// <summary>
    /// Type of the sampled data. Warning: This enumeration is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.
    /// </summary>
    public enum VstatsCounterMetadataSampleTypeEnum
    {
        [EnumMember(Value = "RAW")]
        RAW = 1,
        [EnumMember(Value = "ABSOLUTE")]
        ABSOLUTE = 2,
        [EnumMember(Value = "FRACTION")]
        FRACTION = 3,
        [EnumMember(Value = "RATE")]
        RATE = 4,
        [EnumMember(Value = "DELTA")]
        DELTA = 5,
        [EnumMember(Value = "LOGN")]
        LOGN = 6,
    }
}
