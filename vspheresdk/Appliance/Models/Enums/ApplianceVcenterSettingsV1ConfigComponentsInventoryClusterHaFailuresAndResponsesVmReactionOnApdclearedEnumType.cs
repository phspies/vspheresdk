using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// If an APD condition clears after an APD timeout condition has been declared and before VM Component Protection service terminated the VM, the guestOS and application may no longer be operational.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesVmReactionOnApdclearedEnumType
    {
        [EnumMember(Value = "NONE")]
        NONE = 1,
        [EnumMember(Value = "RESET")]
        RESET = 2,
        [EnumMember(Value = "USE_CLUSTER_DEFAULT")]
        USECLUSTERDEFAULT = 3,
    }
}
