using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// Current run state of VMware Tools in the guest operating system.
    /// </summary>
    public enum VcenterVmToolsRunStateEnumType
    {
        [EnumMember(Value = "NOT_RUNNING")]
        NOTRUNNING = 1,
        [EnumMember(Value = "RUNNING")]
        RUNNING = 2,
        [EnumMember(Value = "EXECUTING_SCRIPTS")]
        EXECUTINGSCRIPTS = 3,
    }
}
