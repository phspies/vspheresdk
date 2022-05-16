using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Hardware.UpgradePolicy enumerated type defines the valid virtual hardware upgrade policies for a virtual machine.
    /// </summary>
    public enum VcenterVmHardwareUpgradePolicyType
    {
        [EnumMember(Value = "NEVER")]
        NEVER = 1,
        [EnumMember(Value = "AFTER_CLEAN_SHUTDOWN")]
        AFTERCLEANSHUTDOWN = 2,
        [EnumMember(Value = "ALWAYS")]
        ALWAYS = 3,
    }
}
