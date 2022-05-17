using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Cluster.NodeState enumerated type defines possible state a node can be in a VCHA Cluster.
    /// </summary>
    public enum VcenterVchaClusterNodeStateEnumType
    {
        [EnumMember(Value = "UP")]
        UP = 1,
        [EnumMember(Value = "DOWN")]
        DOWN = 2,
    }
}
