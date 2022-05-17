using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Job.BackupRestoreProcessState enumerated type defines the possible states of a backup/restore process.
    /// </summary>
    public enum ApplianceRecoveryBackupJobBackupRestoreProcessStateType
    {
        [EnumMember(Value = "FAILED")]
        FAILED = 1,
        [EnumMember(Value = "INPROGRESS")]
        INPROGRESS = 2,
        [EnumMember(Value = "NONE")]
        NONE = 3,
        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED = 4,
    }
}
