using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Details.Type enumerated type defines the type of backup job.
    /// </summary>
    public enum ApplianceRecoveryBackupJobDetailsTypeA
    {
        [EnumMember(Value = "SCHEDULED")]
        SCHEDULED = 1,
        [EnumMember(Value = "MANUAL")]
        MANUAL = 2,
    }
}
