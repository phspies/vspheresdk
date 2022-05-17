using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The NamespaceSelfService.Capability enumerated type describes the self-service namespace capability of the cluster on which vSphere Namespaces enabled.
    /// </summary>
    public enum VcenterNamespacesNamespaceSelfServiceCapabilityEnumType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 1,
        [EnumMember(Value = "SUPPORTED")]
        SUPPORTED = 2,
        [EnumMember(Value = "NOTSUPPORTED")]
        NOTSUPPORTED = 3,
    }
}
