using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum VcenterStoragePoliciesComplianceVMStatusEnumTypeA
    {
        [EnumMember(Value = "COMPLIANT")]
        COMPLIANT = 1,
        [EnumMember(Value = "NON_COMPLIANT")]
        NONCOMPLIANT = 2,
        [EnumMember(Value = "UNKNOWN_COMPLIANCE")]
        UNKNOWNCOMPLIANCE = 3,
        [EnumMember(Value = "NOT_APPLICABLE")]
        NOTAPPLICABLE = 4,
        [EnumMember(Value = "OUT_OF_DATE")]
        OUTOFDATE = 5,
    }
}
