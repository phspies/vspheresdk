using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Tools.UpgradePolicy enumerated type defines when Tools are auto-upgraded for a virtual machine.
    /// </summary>
    public enum VcenterVmToolsUpgradePolicyEnumType
    {
        [EnumMember(Value = "MANUAL")]
        MANUAL = 1,
        [EnumMember(Value = "UPGRADE_AT_POWER_CYCLE")]
        UPGRADEATPOWERCYCLE = 2,
    }
}
