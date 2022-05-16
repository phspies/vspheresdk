using System.Runtime.Serialization;

namespace vspheresdk.Stats.Models.Enums
{
    /// <summary>
    /// The QueryPredicate enum describes how to query an id present in a RsrcId. Warning: This enumeration is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.
    /// </summary>
    public enum VstatsQueryPredicateType
    {
        [EnumMember(Value = "EQUAL")]
        EQUAL = 1,
        [EnumMember(Value = "ALL")]
        ALL = 2,
    }
}
