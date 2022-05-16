using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The ClusterSupervisorServices.ConfigStatus enumerated type describes the status of reaching the desired state configuration for the Supervisor Service.
    /// </summary>
    public enum VcenterNamespaceManagementSupervisorServicesClusterSupervisorServicesConfigStatusType
    {
        [EnumMember(Value = "CONFIGURING")]
        CONFIGURING = 1,
        [EnumMember(Value = "REMOVING")]
        REMOVING = 2,
        [EnumMember(Value = "CONFIGURED")]
        CONFIGURED = 3,
        [EnumMember(Value = "ERROR")]
        ERROR = 4,
    }
}
