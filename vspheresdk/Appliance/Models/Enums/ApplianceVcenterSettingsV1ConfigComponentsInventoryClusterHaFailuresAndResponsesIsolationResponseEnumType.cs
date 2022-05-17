using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The enum defines values that indicate whether or not the virtual machine should be powered off if a host determines that it is isolated from the rest of the cluster.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesIsolationResponseEnumType
    {
        [EnumMember(Value = "NONE")]
        NONE = 1,
        [EnumMember(Value = "POWER_OFF")]
        POWEROFF = 2,
        [EnumMember(Value = "SHUTDOWN")]
        SHUTDOWN = 3,
        [EnumMember(Value = "CLUSTER_ISOLATION_RESPONSE")]
        CLUSTERISOLATIONRESPONSE = 4,
    }
}
