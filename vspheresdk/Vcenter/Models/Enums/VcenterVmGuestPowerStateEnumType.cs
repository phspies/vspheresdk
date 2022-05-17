using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// Possible guest power states.
    /// </summary>
    public enum VcenterVmGuestPowerStateEnumType
    {
        [EnumMember(Value = "RUNNING")]
        RUNNING = 1,
        [EnumMember(Value = "SHUTTING_DOWN")]
        SHUTTINGDOWN = 2,
        [EnumMember(Value = "RESETTING")]
        RESETTING = 3,
        [EnumMember(Value = "STANDBY")]
        STANDBY = 4,
        [EnumMember(Value = "NOT_RUNNING")]
        NOTRUNNING = 5,
        [EnumMember(Value = "UNAVAILABLE")]
        UNAVAILABLE = 6,
    }
}
