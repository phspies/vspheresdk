using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The DrsBehaviorInfo enumerated type defines the automation levels that can be set on a DRS cluster.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsDrsBehaviorInfoEnumType
    {
        [EnumMember(Value = "MANUAL")]
        MANUAL = 1,
        [EnumMember(Value = "PARTIALLY_AUTOMATED")]
        PARTIALLYAUTOMATED = 2,
        [EnumMember(Value = "FULLY_AUTOMATED")]
        FULLYAUTOMATED = 3,
    }
}
