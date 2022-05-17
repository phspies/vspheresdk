using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Ipv4.Mode enumerated type defines different IPv4 address assignment modes.
    /// </summary>
    public enum ApplianceNetworkingInterfacesIpv4ModeType
    {
        [EnumMember(Value = "DHCP")]
        DHCP = 1,
        [EnumMember(Value = "STATIC")]
        STATIC = 2,
        [EnumMember(Value = "UNCONFIGURED")]
        UNCONFIGURED = 3,
    }
}
