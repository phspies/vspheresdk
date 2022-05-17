using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name Status} {@term enumerated type} defines the status result for a particular check.
    /// </summary>
    public enum EsxSettingsClustersSoftwareReportsLastCheckResultStatusType
    {
        [EnumMember(Value = "OK")]
        OK = 1,
        [EnumMember(Value = "WARNING")]
        WARNING = 2,
        [EnumMember(Value = "TIMEOUT")]
        TIMEOUT = 3,
        [EnumMember(Value = "ERROR")]
        ERROR = 4,
    }
}
