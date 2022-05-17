using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Job.LocationType enumerated type defines the type of destination location for backup/restore. You specify the location type when you create a backup job. See Job.BackupRequest.
    /// </summary>
    public enum ApplianceRecoveryBackupJobLocationType
    {
        [EnumMember(Value = "FTP")]
        FTP = 1,
        [EnumMember(Value = "HTTP")]
        HTTP = 2,
        [EnumMember(Value = "FTPS")]
        FTPS = 3,
        [EnumMember(Value = "HTTPS")]
        HTTPS = 4,
        [EnumMember(Value = "SCP")]
        SCP = 5,
        [EnumMember(Value = "SFTP")]
        SFTP = 6,
        [EnumMember(Value = "NFS")]
        NFS = 7,
        [EnumMember(Value = "SMB")]
        SMB = 8,
    }
}
