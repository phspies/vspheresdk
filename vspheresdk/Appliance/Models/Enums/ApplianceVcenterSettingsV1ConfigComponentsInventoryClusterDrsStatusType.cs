using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Status enumeration defines a general &quot;health&quot; value for a managed entity.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsStatusType
    {
        [EnumMember(Value = "GRAY")]
        GRAY = 1,
        [EnumMember(Value = "GREEN")]
        GREEN = 2,
        [EnumMember(Value = "YELLOW")]
        YELLOW = 3,
        [EnumMember(Value = "RED")]
        RED = 4,
    }
}
