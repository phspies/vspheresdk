using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The ResourcePool.SharesInfo.Level enumerated type defines the possible values for the allocation level.
    /// </summary>
    public enum VcenterResourcePoolSharesInfoLevelEnumTypeA
    {
        [EnumMember(Value = "LOW")]
        LOW = 1,
        [EnumMember(Value = "NORMAL")]
        NORMAL = 2,
        [EnumMember(Value = "HIGH")]
        HIGH = 3,
        [EnumMember(Value = "CUSTOM")]
        CUSTOM = 4,
    }
}
