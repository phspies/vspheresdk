using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Forwarding.Protocol enumerated type defines transport protocols for outbound log messages.
    /// </summary>
    public enum ApplianceLoggingForwardingProtocolTypeA
    {
        [EnumMember(Value = "TLS")]
        TLS = 1,
        [EnumMember(Value = "UDP")]
        UDP = 2,
        [EnumMember(Value = "TCP")]
        TCP = 3,
    }
}
