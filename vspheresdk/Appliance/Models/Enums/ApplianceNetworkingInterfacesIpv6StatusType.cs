using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Ipv6.Status enumerated type defines IPv6 address status values. See RFC 4293.
    /// </summary>
    public enum ApplianceNetworkingInterfacesIpv6StatusType
    {
        [EnumMember(Value = "TENTATIVE")]
        TENTATIVE = 1,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 2,
        [EnumMember(Value = "INACCESSIBLE")]
        INACCESSIBLE = 3,
        [EnumMember(Value = "INVALID")]
        INVALID = 4,
        [EnumMember(Value = "DUPLICATE")]
        DUPLICATE = 5,
        [EnumMember(Value = "PREFERRED")]
        PREFERRED = 6,
        [EnumMember(Value = "DEPRECATED")]
        DEPRECATED = 7,
        [EnumMember(Value = "OPTIMISTIC")]
        OPTIMISTIC = 8,
    }
}
