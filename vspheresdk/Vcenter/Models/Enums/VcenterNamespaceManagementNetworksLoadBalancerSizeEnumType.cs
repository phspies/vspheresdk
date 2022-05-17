using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Networks.LoadBalancerSize enumerates the kinds of load balancer sizes supported by NSX. Small load balancer can host 10 to 20 virtual servers depending on NSX-T version. Medium load balancer can host 100 virtual servers. Large load balancer can host 1000 virtual servers.
    /// </summary>
    public enum VcenterNamespaceManagementNetworksLoadBalancerSizeEnumType
    {
        [EnumMember(Value = "SMALL")]
        SMALL = 1,
        [EnumMember(Value = "MEDIUM")]
        MEDIUM = 2,
        [EnumMember(Value = "LARGE")]
        LARGE = 3,
    }
}
