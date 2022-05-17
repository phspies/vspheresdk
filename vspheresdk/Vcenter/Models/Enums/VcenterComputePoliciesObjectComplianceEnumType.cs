using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The {@name ObjectCompliance} {@term enumerated type} defines the compliance states a policy can be in on a particular object.
    /// </summary>
    public enum VcenterComputePoliciesObjectComplianceEnumType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 1,
        [EnumMember(Value = "NOT_APPLICABLE")]
        NOTAPPLICABLE = 2,
        [EnumMember(Value = "COMPLIANT")]
        COMPLIANT = 3,
        [EnumMember(Value = "NOT_COMPLIANT")]
        NOTCOMPLIANT = 4,
    }
}
