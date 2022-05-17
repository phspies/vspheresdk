using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplianceSupportBundleCreationStatusType
    {
        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED = 1,
        [EnumMember(Value = "FAILED")]
        FAILED = 2,
        [EnumMember(Value = "CANCELLED")]
        CANCELLED = 3,
    }
}
