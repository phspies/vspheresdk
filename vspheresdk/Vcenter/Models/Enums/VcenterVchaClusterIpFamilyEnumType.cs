using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Cluster.IpFamily enumerated type defines the IP address family.
    /// </summary>
    public enum VcenterVchaClusterIpFamilyEnumType
    {
        [EnumMember(Value = "IPV4")]
        IPV4 = 1,
        [EnumMember(Value = "IPV6")]
        IPV6 = 2,
    }
}
