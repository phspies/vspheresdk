using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The enum defines virtual machine restart priority values to resolve resource contention. The priority determines the preference that HA gives to a virtual machine if sufficient capacity is not available to power on all failed virtual machines. For example, high priority virtual machines on a host get preference over low priority virtual machines.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesRestartPriorityEnumType
    {
        [EnumMember(Value = "DISABLED")]
        DISABLED = 1,
        [EnumMember(Value = "LOWEST")]
        LOWEST = 2,
        [EnumMember(Value = "LOW")]
        LOW = 3,
        [EnumMember(Value = "MEDIUM")]
        MEDIUM = 4,
        [EnumMember(Value = "HIGH")]
        HIGH = 5,
        [EnumMember(Value = "HIGHEST")]
        HIGHEST = 6,
        [EnumMember(Value = "CLUSTER_RESTART_PRIORITY")]
        CLUSTERRESTARTPRIORITY = 7,
    }
}
