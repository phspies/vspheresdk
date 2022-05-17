using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Interfaces.InterfaceStatus enumerated type Defines interface status
    /// </summary>
    public enum ApplianceNetworkingInterfacesInterfaceStatusEnumType
    {
        [EnumMember(Value = "DOWN")]
        Down = 1,
        [EnumMember(Value = "UP")]
        Up = 2,
    }
}
