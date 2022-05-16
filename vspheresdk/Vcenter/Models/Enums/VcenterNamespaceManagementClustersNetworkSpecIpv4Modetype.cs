using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Clusters.NetworkSpec.Ipv4Mode enumerated type defines various IPv4 address assignment modes.
    /// </summary>
    public enum VcenterNamespaceManagementClustersNetworkSpecIpv4ModeType
    {
        [EnumMember(Value = "DHCP")]
        DHCP = 1,
        [EnumMember(Value = "STATICRANGE")]
        STATICRANGE = 2,
    }
}
