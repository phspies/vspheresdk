using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Interfaces.IpAddressOrigin enumerated type specifies how an IP address was obtained for an interface. See RFC 4293 IpAddressOriginTC.
    /// </summary>
    public enum VcenterVmGuestNetworkingInterfacesIpAddressOriginEnumType
    {
        [EnumMember(Value = "OTHER")]
        OTHER = 1,
        [EnumMember(Value = "MANUAL")]
        MANUAL = 2,
        [EnumMember(Value = "DHCP")]
        DHCP = 3,
        [EnumMember(Value = "LINKLAYER")]
        LINKLAYER = 4,
        [EnumMember(Value = "RANDOM")]
        RANDOM = 5,
    }
}
