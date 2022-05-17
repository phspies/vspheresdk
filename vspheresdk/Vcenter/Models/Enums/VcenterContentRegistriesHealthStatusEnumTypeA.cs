using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The {@name Status} {@term enumerated type} describes the status of the container registry.
    /// </summary>
    public enum VcenterContentRegistriesHealthStatusEnumTypeA
    {
        [EnumMember(Value = "STARTING")]
        STARTING = 1,
        [EnumMember(Value = "RUNNING")]
        RUNNING = 2,
        [EnumMember(Value = "WARNING")]
        WARNING = 3,
        [EnumMember(Value = "ERROR")]
        ERROR = 4,
        [EnumMember(Value = "DELETING")]
        DELETING = 5,
    }
}
