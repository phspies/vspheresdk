using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Ipv6.Type enumerated type specifies different types of the IPv6 configuration.
    /// </summary>
    public enum VcenterGuestIpv6TypeEnum
    {
        [EnumMember(Value = "DHCP")]
        DHCP = 1,
        [EnumMember(Value = "STATIC")]
        STATIC = 2,
        [EnumMember(Value = "USER_INPUT_REQUIRED")]
        USERINPUTREQUIRED = 3,
    }
}
