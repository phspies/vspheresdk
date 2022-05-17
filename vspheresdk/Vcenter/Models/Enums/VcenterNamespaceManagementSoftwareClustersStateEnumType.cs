using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Clusters.State enumerated type describes the state of the upgrade.
    /// </summary>
    public enum VcenterNamespaceManagementSoftwareClustersStateEnumType
    {
        [EnumMember(Value = "PENDING")]
        PENDING = 1,
        [EnumMember(Value = "READY")]
        READY = 2,
        [EnumMember(Value = "ERROR")]
        ERROR = 3,
    }
}
