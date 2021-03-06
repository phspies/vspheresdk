using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The {@name Recurrence} {@term enumerated type} defines the supported values for how often to run a specific operation for a container registry.
    /// </summary>
    public enum VcenterContentRegistriesRecurrenceEnumType
    {
        [EnumMember(Value = "NONE")]
        NONE = 1,
        [EnumMember(Value = "DAILY")]
        DAILY = 2,
        [EnumMember(Value = "WEEKLY")]
        WEEKLY = 3,
    }
}
