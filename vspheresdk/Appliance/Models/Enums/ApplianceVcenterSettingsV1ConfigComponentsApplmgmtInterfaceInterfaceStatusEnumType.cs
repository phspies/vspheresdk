using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Interface.InterfaceStatus enumerated type Defines interface status
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsApplmgmtInterfaceInterfaceStatusEnumType
    {
        [EnumMember(Value = "DOWN")]
        DOWN = 1,
        [EnumMember(Value = "UP")]
        UP = 2,
    }
}
