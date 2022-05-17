using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Cluster.ClusterState enumerated type defines the possible for a VCHA Cluster.
    /// </summary>
    public enum VcenterVchaClusterClusterStateEnumType
    {
        [EnumMember(Value = "HEALTHY")]
        HEALTHY = 1,
        [EnumMember(Value = "DEGRADED")]
        DEGRADED = 2,
        [EnumMember(Value = "ISOLATED")]
        ISOLATED = 3,
    }
}
