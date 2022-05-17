using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The DpmBehaviorInfo enumerated type defines the automation level for DPM service on a cluster.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsDpmBehaviorInfoType
    {
        [EnumMember(Value = "MANUAL")]
        MANUAL = 1,
        [EnumMember(Value = "AUTOMATED")]
        AUTOMATED = 2,
    }
}
