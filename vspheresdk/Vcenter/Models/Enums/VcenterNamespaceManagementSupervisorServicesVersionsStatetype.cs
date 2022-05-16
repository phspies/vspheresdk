using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Versions.State enumerated type defines the state of a Supervisor Service version.
    /// </summary>
    public enum VcenterNamespaceManagementSupervisorServicesVersionsStateType
    {
        [EnumMember(Value = "ACTIVATED")]
        ACTIVATED = 1,
        [EnumMember(Value = "DEACTIVATED")]
        DEACTIVATED = 2,
    }
}
