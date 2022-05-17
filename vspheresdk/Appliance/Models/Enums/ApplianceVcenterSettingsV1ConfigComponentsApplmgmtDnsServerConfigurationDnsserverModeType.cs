using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// DnsServerConfiguration.DNSServerMode enumerated type Describes DNS Server source (DHCP,static).
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsApplmgmtDnsServerConfigurationDnsserverModeType
    {
        [EnumMember(Value = "DHCP")]
        DHCP = 1,
        [EnumMember(Value = "IS_STATIC")]
        ISSTATIC = 2,
    }
}
