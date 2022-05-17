using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Possible states of an HA service. All services support the disabled and enabled states.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesServiceStateEnumType
    {
        [EnumMember(Value = "DISABLED")]
        DISABLED = 1,
        [EnumMember(Value = "ENABLED")]
        ENABLED = 2,
    }
}
