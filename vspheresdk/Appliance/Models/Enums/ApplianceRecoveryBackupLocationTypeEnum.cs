using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Backup.LocationType enumerated type Defines type of all locations for backup/restore
    /// </summary>
    public enum ApplianceRecoveryBackupLocationTypeEnum
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
