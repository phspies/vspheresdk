using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// The {@name SecurityRuleType} {@term enumerated type} defines the security rules which can be applied to different item types.
    /// </summary>
    public enum ContentSecurityRuleTypeEnumA
    {
        [EnumMember(Value = "OVF_STRICT_VERIFICATION")]
        OVFSTRICTVERIFICATION = 1,
    }
}
