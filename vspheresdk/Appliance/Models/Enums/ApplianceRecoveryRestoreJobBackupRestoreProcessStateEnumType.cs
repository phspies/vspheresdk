using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Job.BackupRestoreProcessState enumerated type Defines state of backup/restore process
    /// </summary>
    public enum ApplianceRecoveryRestoreJobBackupRestoreProcessStateEnumType
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
