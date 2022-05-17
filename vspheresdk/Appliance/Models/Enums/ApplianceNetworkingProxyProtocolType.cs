using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Proxy.Protocol enumerated type defines the protocols for which proxying is supported.
    /// </summary>
    public enum ApplianceNetworkingProxyProtocolType
    {
        [EnumMember(Value = "HTTP")]
        HTTP = 1,
        [EnumMember(Value = "HTTPS")]
        HTTPS = 2,
        [EnumMember(Value = "FTP")]
        FTP = 3,
    }
}
