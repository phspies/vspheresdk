using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Clusters.KubernetesStatus enumerated type describes the cluster&apos;s ability to deploy pods.
    /// </summary>
    public enum VcenterNamespaceManagementClustersKubernetesStatusEnumType
    {
        [EnumMember(Value = "READY")]
        READY = 1,
        [EnumMember(Value = "WARNING")]
        WARNING = 2,
        [EnumMember(Value = "ERROR")]
        ERROR = 3,
    }
}
