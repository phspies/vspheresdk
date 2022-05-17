using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Compliance.Status enumerated type defines the storage compliance status of a virtual machine and its applicable entities.
    /// </summary>
    public enum VcenterVmStoragePolicyComplianceStatusEnumTypeA
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
