using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Servers.DNSServerMode enumerated type Describes DNS Server source (DHCP,static)
    /// </summary>
    public enum ApplianceNetworkingDnsServersDnsserverModeType
    {
        [EnumMember(Value = "DHCP")]
        Dhcp = 1,
        [EnumMember(Value = "IS_STATIC")]
        IsStatic = 2,
    }
}
