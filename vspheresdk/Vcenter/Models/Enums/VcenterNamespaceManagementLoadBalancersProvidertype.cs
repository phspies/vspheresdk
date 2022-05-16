using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The LoadBalancers.Provider enumerates the kinds of load balancers supported by vSphere Namespaces.
    /// </summary>
    public enum VcenterNamespaceManagementLoadBalancersProviderType
    {
        [EnumMember(Value = "HA_PROXY")]
        HAPROXY = 1,
        [EnumMember(Value = "AVI")]
        AVI = 2,
    }
}
