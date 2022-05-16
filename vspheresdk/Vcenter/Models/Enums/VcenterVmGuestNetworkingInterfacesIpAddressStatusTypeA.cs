using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Interfaces.IpAddressStatus enumerated type defines the present status of an address on an interface. See RFC 4293 IpAddressStatusTC.
    /// </summary>
    public enum VcenterVmGuestNetworkingInterfacesIpAddressStatusTypeA
    {
        [EnumMember(Value = "PREFERRED")]
        PREFERRED = 1,
        [EnumMember(Value = "DEPRECATED")]
        DEPRECATED = 2,
        [EnumMember(Value = "INVALID")]
        INVALID = 3,
        [EnumMember(Value = "INACCESSIBLE")]
        INACCESSIBLE = 4,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 5,
        [EnumMember(Value = "TENTATIVE")]
        TENTATIVE = 6,
        [EnumMember(Value = "DUPLICATE")]
        DUPLICATE = 7,
    }
}
