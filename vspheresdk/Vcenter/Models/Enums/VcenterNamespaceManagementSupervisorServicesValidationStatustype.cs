using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The SupervisorServices.ValidationStatus enumerated type defines the type of status for validating content of a Supervisor Service version.
    /// </summary>
    public enum VcenterNamespaceManagementSupervisorServicesValidationStatusType
    {
        [EnumMember(Value = "VALID")]
        VALID = 1,
        [EnumMember(Value = "VALID_WITH_WARNINGS")]
        VALIDWITHWARNINGS = 2,
        [EnumMember(Value = "INVALID")]
        INVALID = 3,
    }
}
