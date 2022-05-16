using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The page describes the status of the namespace self-service on the cluster on which vSphere Namespaces enabled.
    /// </summary>
    public enum VcenterNamespacesNamespaceSelfServiceStatusType
    {
        [EnumMember(Value = "CONFIGURING")]
        CONFIGURING = 1,
        [EnumMember(Value = "RUNNING")]
        RUNNING = 2,
        [EnumMember(Value = "REMOVING")]
        REMOVING = 3,
        [EnumMember(Value = "DEACTIVATED")]
        DEACTIVATED = 4,
        [EnumMember(Value = "ERROR")]
        ERROR = 5,
    }
}
