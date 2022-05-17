using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The ProactiveHAConfig.BehaviorType enumerated type defines the behavior for executing the proposed DRS recommendations.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsProactiveHaconfigBehaviorType
    {
        [EnumMember(Value = "MANUAL")]
        MANUAL = 1,
        [EnumMember(Value = "AUTOMATED")]
        AUTOMATED = 2,
    }
}
