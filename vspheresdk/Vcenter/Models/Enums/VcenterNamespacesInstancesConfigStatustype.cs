using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Instances.ConfigStatus enumerated type describes the status of reaching the desired state configuration for the namespace.
    /// </summary>
    public enum VcenterNamespacesInstancesConfigStatusType
    {
        [EnumMember(Value = "CONFIGURING")]
        CONFIGURING = 1,
        [EnumMember(Value = "REMOVING")]
        REMOVING = 2,
        [EnumMember(Value = "RUNNING")]
        RUNNING = 3,
        [EnumMember(Value = "ERROR")]
        ERROR = 4,
    }
}
