using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The HistoryMigrationOption enumerated type defines the vCenter history migration option choices.
    /// </summary>
    public enum VcenterDeploymentHistoryMigrationOptionType
    {
        [EnumMember(Value = "EVENTS_TASKS")]
        EVENTSTASKS = 1,
        [EnumMember(Value = "ALL")]
        ALL = 2,
    }
}
