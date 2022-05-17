using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Clusters.Result.Res enumerated type represents the upgrade invocation result for each cluster.
    /// </summary>
    public enum VcenterNamespaceManagementSoftwareClustersResultResEnumType
    {
        [EnumMember(Value = "STARTED")]
        STARTED = 1,
        [EnumMember(Value = "REJECTED")]
        REJECTED = 2,
    }
}
