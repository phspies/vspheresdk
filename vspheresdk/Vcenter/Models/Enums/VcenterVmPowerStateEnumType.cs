using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum VcenterVmPowerStateEnumType
    {
        [EnumMember(Value = "POWERED_OFF")]
        POWEREDOFF = 1,
        [EnumMember(Value = "POWERED_ON")]
        POWEREDON = 2,
        [EnumMember(Value = "SUSPENDED")]
        SUSPENDED = 3,
    }
}
