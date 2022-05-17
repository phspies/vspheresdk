using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The VM policy settings that determine the response to storage failures.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesStorageVmReactionType
    {
        [EnumMember(Value = "DISABLED")]
        DISABLED = 1,
        [EnumMember(Value = "WARNING")]
        WARNING = 2,
        [EnumMember(Value = "RESTART_CONSERVATIVE")]
        RESTARTCONSERVATIVE = 3,
        [EnumMember(Value = "RESTART_AGGRESSIVE")]
        RESTARTAGGRESSIVE = 4,
        [EnumMember(Value = "CLUSTER_DEFAULT")]
        CLUSTERDEFAULT = 5,
    }
}
