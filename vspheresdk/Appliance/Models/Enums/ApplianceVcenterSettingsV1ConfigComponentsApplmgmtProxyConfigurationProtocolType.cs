using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// ProxyConfiguration.Protocol enumerated type defines the protocols for which proxying is supported.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsApplmgmtProxyConfigurationProtocolType
    {
        [EnumMember(Value = "HTTP")]
        HTTP = 1,
        [EnumMember(Value = "HTTPS")]
        HTTPS = 2,
        [EnumMember(Value = "FTP")]
        FTP = 3,
    }
}
