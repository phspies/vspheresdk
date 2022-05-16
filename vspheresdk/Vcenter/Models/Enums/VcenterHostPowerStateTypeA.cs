using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Host.PowerState enumerated type defines the power states of a host.
    /// </summary>
    public enum VcenterHostPowerStateTypeA
    {
        [EnumMember(Value = "POWERED_ON")]
        POWEREDON = 1,
        [EnumMember(Value = "POWERED_OFF")]
        POWEREDOFF = 2,
        [EnumMember(Value = "STANDBY")]
        STANDBY = 3,
    }
}
