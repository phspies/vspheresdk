using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The {@name ConfigStatus} {@term enumerated type} describes the status of reaching the desired configuration state for the Harbor project.
    /// </summary>
    public enum VcenterContentRegistriesHarborProjectsConfigStatusType
    {
        [EnumMember(Value = "PENDING")]
        PENDING = 1,
        [EnumMember(Value = "REMOVING")]
        REMOVING = 2,
        [EnumMember(Value = "ERROR")]
        ERROR = 3,
        [EnumMember(Value = "READY")]
        READY = 4,
    }
}
