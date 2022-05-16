using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Mode.ClusterMode enumerated type defines the possible modes for a VCHA Cluster.
    /// </summary>
    public enum VcenterVchaClusterModeClusterModeTypeA
    {
        [EnumMember(Value = "ENABLED")]
        ENABLED = 1,
        [EnumMember(Value = "DISABLED")]
        DISABLED = 2,
        [EnumMember(Value = "MAINTENANCE")]
        MAINTENANCE = 3,
    }
}
