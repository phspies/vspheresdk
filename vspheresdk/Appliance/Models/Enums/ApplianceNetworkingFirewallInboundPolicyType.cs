using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Inbound.Policy enumerated type Defines firewall rule policies.
    /// </summary>
    public enum ApplianceNetworkingFirewallInboundPolicyType
    {
        [EnumMember(Value = "IGNORE")]
        IGNORE = 1,
        [EnumMember(Value = "ACCEPT")]
        ACCEPT = 2,
        [EnumMember(Value = "REJECT")]
        REJECT = 3,
        [EnumMember(Value = "RETURN")]
        RETURN = 4,
    }
}
