using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// Level of severity for applying a given patch or update.
    /// </summary>
    public enum VcenterLcmUpdatePendingSeverityTypeEnum
    {
        [EnumMember(Value = "CRITICAL")]
        CRITICAL = 1,
        [EnumMember(Value = "IMPORTANT")]
        IMPORTANT = 2,
        [EnumMember(Value = "MODERATE")]
        MODERATE = 3,
        [EnumMember(Value = "LOW")]
        LOW = 4,
    }
}
