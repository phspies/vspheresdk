using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The SupervisorServices.State enumerated type defines the state of a Supervisor Service.
    /// </summary>
    public enum VcenterNamespaceManagementSupervisorServicesStateEnumType
    {
        [EnumMember(Value = "ACTIVATED")]
        ACTIVATED = 1,
        [EnumMember(Value = "DEACTIVATED")]
        DEACTIVATED = 2,
    }
}
