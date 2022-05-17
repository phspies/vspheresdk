using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Ipv6.Origin enumerated type defines IPv6 address origin values.
    /// </summary>
    public enum ApplianceNetworkingInterfacesIpv6OriginEnumType
    {
        [EnumMember(Value = "DHCP")]
        DHCP = 1,
        [EnumMember(Value = "RANDOM")]
        RANDOM = 2,
        [EnumMember(Value = "MANUAL")]
        MANUAL = 3,
        [EnumMember(Value = "LINKLAYER")]
        LINKLAYER = 4,
        [EnumMember(Value = "OTHER")]
        OTHER = 5,
    }
}
