using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Cluster.NodeRole enumerated type defines the role node can be in a VCHA Cluster.
    /// </summary>
    public enum VcenterVchaClusterNodeRoleType
    {
        [EnumMember(Value = "ACTIVE")]
        ACTIVE = 1,
        [EnumMember(Value = "PASSIVE")]
        PASSIVE = 2,
        [EnumMember(Value = "WITNESS")]
        WITNESS = 3,
    }
}
