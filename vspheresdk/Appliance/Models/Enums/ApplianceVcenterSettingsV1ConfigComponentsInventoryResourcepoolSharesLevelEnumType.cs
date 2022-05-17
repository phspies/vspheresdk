using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Shares.Level enumerated type defines the possible values for the allocation level.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsInventoryResourcepoolSharesLevelEnumType
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
