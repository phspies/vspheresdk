using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The SizingHint enumerated type determines the configuration of Kubernetes API server and the worker nodes. It also determines the default values associated with the maximum number of pods and services. Use ClusterSizeInfo.get to get information associated with a SizingHint.
    /// </summary>
    public enum VcenterNamespaceManagementSizingHintType
    {
        [EnumMember(Value = "TINY")]
        TINY = 1,
        [EnumMember(Value = "SMALL")]
        SMALL = 2,
        [EnumMember(Value = "MEDIUM")]
        MEDIUM = 3,
        [EnumMember(Value = "LARGE")]
        LARGE = 4,
    }
}
