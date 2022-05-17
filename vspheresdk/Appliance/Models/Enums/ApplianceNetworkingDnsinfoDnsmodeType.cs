using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Networking.DnsInfo.DnsMode enumerated type describes the source of DNS servers.
    /// </summary>
    public enum ApplianceNetworkingDnsinfoDnsmodeType
    {
        [EnumMember(Value = "DHCP")]
        DHCP = 1,
        [EnumMember(Value = "STATIC")]
        STATIC = 2,
    }
}
