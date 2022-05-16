using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Hardware.UpgradeStatus enumerated type defines the valid virtual hardware upgrade statuses for a virtual machine.
    /// </summary>
    public enum VcenterVmHardwareUpgradeStatusType
    {
        [EnumMember(Value = "NONE")]
        NONE = 1,
        [EnumMember(Value = "PENDING")]
        PENDING = 2,
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 3,
        [EnumMember(Value = "FAILED")]
        FAILED = 4,
    }
}
