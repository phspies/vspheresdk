using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The WindowsNetworkAdapterSettings.NetBIOSMode enumerated type specifies different NetBIOS settings for Windows guest operating systems.
    /// </summary>
    public enum VcenterGuestWindowsNetworkAdapterSettingsNetBIOSModeEnumTypeA
    {
        [EnumMember(Value = "USE_DHCP")]
        USEDHCP = 1,
        [EnumMember(Value = "ENABLE")]
        ENABLE = 2,
        [EnumMember(Value = "DISABLE")]
        DISABLE = 3,
    }
}
